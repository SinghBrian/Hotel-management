using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_management.Data;
using Hotel_management.Models;
using Hotel_management.ModelUser;
using Hotel_management.Interfaces;
using Hotel_management.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Hotel_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("devCorsPolicy")]
    public class ClientsController : ControllerBase
    {
        private readonly Hotel_managementContext _context;
        private readonly IClientService _clientService;
        private IConfiguration _config;

        public ClientsController(Hotel_managementContext context, IClientService clientServicess, IConfiguration config)
        {
            _context = context;
            _clientService = clientServicess;
            _config = config;
        }
        // GET Hotel by Criteria

        [HttpGet]
        [Route("GetHotelByCriteria/{size}/{stars}/{destinations}")]

        public ActionResult<List<Hotels>> GetHotelByCriteria (string size, string stars, string destinations)
        {
            try
            {
                RequestBodyCriteria crit = new RequestBodyCriteria()
                {
                    Criteria_size = size,
                    Criteria_stars = stars,
                    destination = destinations,
                };
                var hot = _clientService.Gethotels(crit);
                if (hot.Count >= 1)
                {
                    return Ok(hot);
                }
                else
                {
                    return BadRequest("Pas d'hotel trouvé !");
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Get Client Login
        [HttpGet]
        [Route("GetClientLogin/{Name}/{pswd}/{email}/{number}")]
        public ActionResult<bool> GetClientLogin(string Name, string pswd, string email, string number)
        {
            RequestBodyLoginClient cs = new RequestBodyLoginClient()
            {
                Name=Name,
                Password=pswd,
                email=email,
                TelephoneNumber=number,
            };
            var cl = _clientService.GetClientLogin(cs);
            if (cl == false)
            {

                return NotFound("Client pas reconnu !");
            }
            string token = cs.Token = GenerateToken(cs);
            return Ok(true);
            
            
        }

        //Création nouveau client
        [HttpPost]
        [Route("PostClientLogin/{Name}/{pswd}/{email}/{number}")]
        public ActionResult<bool> PostClientLogin(string Name, string pswd, string email, string number)
        {
            RequestBodyLoginClient cs = new RequestBodyLoginClient()
            {
                Name = Name,
                Password = pswd,
                email = email,
                TelephoneNumber = number,
            };
            if (cs != null)
            {
                var testClient = _clientService.CheckClientName(cs.Name);
                if (testClient == false)
                {


                    var cl = _clientService.PostNewClientLogin(cs);
                    if (cl == false)
                    {

                        return NotFound("Veuillez renseigner tous les champs !");
                    }
                    string token = cs.Token = GenerateToken(cs);
                    return Ok(true);
                }
                return NotFound("Nom de Client déjà existant !");
            }
            return NotFound("Champs mal renseigné !");
        }
        //Generate Token JWt
        private string GenerateToken(RequestBodyLoginClient cl)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                        _config["Jwt:Issuer"],
                        null,
                        expires: DateTime.Now.AddMinutes(120),
                        signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //Création d'une réservation

        [HttpPost]
        [Route("PostReservation/{checkin}/{checkout}/{nbA}/{nbC}/{HotName}/{chCat}/{ClientN}/{servSupp}")]
        public Concerner PostReservation(string checkin, string checkout, string nbA, string nbC, string HotName, string chCat, string ClientN,string servSupp)
        {
            DateTime checkins = DateTime.Parse(checkin);
            DateTime checkouts = DateTime.Parse(checkout);
            int nbAs = int.Parse(nbA);
            int nbCs = int.Parse(nbC);
            int servSupps = int.Parse(servSupp);
            //appeler les diiférentes interfaces.
            
            var response = _clientService.PostReservation(checkins, checkouts, nbAs, nbCs, HotName, chCat, ClientN,servSupps);
            return response;

        }
        //res pour admin
        [HttpPost("PostReservationAdmin")]

        public bool PostReservationAdmin([FromBody] RequestBodyAdmin res)
        {
            DateTime checkins = DateTime.Parse(res.checkin);
            DateTime checkouts = DateTime.Parse(res.checkout);
            int nbAs = int.Parse(res.adult);
            int nbCs = int.Parse(res.child);
            int servSupps = int.Parse(res.services);
            //appeler les diiférentes interfaces.
            
            var response = _clientService.PostReservation(checkins, checkouts, nbAs, nbCs, res.hotel, res.chamber, res.client, servSupps);
            if (response != null)
            {
                return true;
            }
            return false;
        }


        [HttpGet]
        [Route("GetFullReservation/{ClientName}")]
        public List<Reservation> GetFullReservation(string ClientName)
        {
            return _clientService.GetFullReservation(ClientName);
        }

        [HttpPost]
        [Route("ClientToComm/{cliName}/{texte}")]

        public Commentaire ClientToComm(string cliName, string texte)
        {
            var response = _clientService.ClientToComm(cliName, texte);
            return response;
        }

        [HttpGet]
        [Route("getComments/{cliName}")]
        public List<Commentaire> getComments(string cliName)
        {
            return _clientService.getComments(cliName);
        }

        [HttpPut]
        [Route("modifyClient/{clientN}/{pswdd}/{num}/{email}")]

        public bool modifyClient(string clientN, string pswdd, string num, string email)
        {
            return _clientService.modifyClient(clientN, pswdd, num, email);
        }
        //Lien auto-généré par le controlleur de vs studio
        // GET: api/Clients
        /*[HttpGet]
        [Route("GetClientReservation/{name}")]
        public List<Reservation> GetClientReservation(string name)
        {
            var result = _context.Reservation.Where(c => c.ClientName == name).ToList();
            return result;
        }*/

        // GET: api/Clients/5
        
    }
}
