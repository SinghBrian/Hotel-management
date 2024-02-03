using Hotel_management.Data;
using Hotel_management.Interfaces;
using Hotel_management.Models;
using Hotel_management.ModelUser;
using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Hotel_management.Repository
{
    public class ClientRepo : IClientRepo
    {
        private readonly Hotel_managementContext _context;
         string _connectionString="";
        public ClientRepo(Hotel_managementContext context,IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("Hotel_managementContext");
        }

        //Avoir la liste des hotesl selon les critères.

        public  List<Hotels> GetHotelByCriteria (RequestBodyCriteria criteria)
        {
           
            if (criteria.Criteria_size == "0" && criteria.Criteria_stars == "0" && criteria.destination == "0")
            {
                return _context.Hotels.ToList();
            }
            var HotelCrit = _context.Hotels.Where(c => c.destination == criteria.destination || c.Criteria_size == criteria.Criteria_size || c.Criteria_stars == criteria.Criteria_stars).ToList();
           
            return HotelCrit;
        }

        //Login Client existant 
        public bool GetClientLogin(RequestBodyLoginClient cs)
        {
            if (cs != null) 
            { 
            var clientss = _context.Client.FirstOrDefault(c => c.Name == cs.Name && c.Password == cs.Password);
                if(clientss != null) 
                {
                    return true;
                }
                
            }
           
            return false;
        }
        //Vérif Nom de client déjà existant

        public bool CheckClientName(string name)
        {
            var client = _context.Client.FirstOrDefault(c=>c.Name == name);
            if (client == null)
            {
                return false;
            }
            return true;
        }
        //Ajout d'un nouveau client

        public bool PostNewClientLogin(RequestBodyLoginClient cs)
        {
            if (cs.email != "" && cs.Name != "" && cs.TelephoneNumber != "" && cs.Password != "")
            {
                var clientss = _context.Client.FirstOrDefault(c => c.Name == cs.Name && c.Password == cs.Password);

                if (clientss == null)
                {
                    Client cl = new Client
                    {
                        Name = cs.Name,
                        email = cs.email,
                        Password = cs.Password,
                        TelephoneNumber = cs.TelephoneNumber,
                        
                    };
                    _context.Client.Add(cl);
                    _context.SaveChanges();
                }
                return true;
            }

            return false;
        }
        //get saisons
        public Saison GetSaisons(DateTime checkin, DateTime checkout)
        {
            var sai = _context.Saisons.FirstOrDefault(x => x.DateDebut <= checkin && x.DateFin >= checkout);
            return sai;
        }

        //ajout chambre
        public Chambre AddChamber()
        {
            Chambre ch = new Chambre();
            _context.Chambre.Add(ch);
            _context.SaveChanges();
            return ch;
        }
        //Assignation Prix
        public Tarifs GetTarifss(string libsaison, string chCat)
        {
            ICollection<Saison> sais = new Collection<Saison>();
            sais.Add(_context.Saisons.FirstOrDefault(x=>x.Libelle== libsaison));
            if (libsaison == "Normal" && chCat =="Single")
            {

                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 80);
                trf.Saisons=sais;
                return trf;
            }else if(libsaison == "High" && chCat == "Single")
            {
                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 100);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "Low" && chCat == "Single")
            {
                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 60);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "Normal" && chCat == "Double")
            {

                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 130);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "High" && chCat == "Double")
            {
                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 170);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "Low" && chCat == "Double")
            {
                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 110);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "Low" && chCat == "Suite")
            {
                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 340);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "Normal" && chCat == "Suite")
            {

                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 360);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "High" && chCat == "Suite")
            {
                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 400);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "Low" && chCat == "Suite Presidential")
            {
                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 760);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "Normal" && chCat == "Suite Presidential")
            {

                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 780);
                trf.Saisons = sais;
                return trf;
            }
            else if (libsaison == "High" && chCat == "Suite Presidential")
            {
                var trf = _context.Tarifss.FirstOrDefault(c => c.PrixCat == 800);
                trf.Saisons = sais;
                return trf;
            }
            return new Tarifs();
        }

        //avoir la réservation après l'ajout
        public List<Reservation> GetFullReservation(string clientName)
        {
            return _context.Reservation.Where(c=>c.ClientName == clientName).ToList();
        }

        //reservation
        public Reservation GetReservation(string cli,int tf, int persA, int persB, int servSupp, int totalDays)
        {
           
            //Calcul du montant
            int totals = (tf + (persA*50) + (persB*20)+(servSupp*1))*totalDays;
            ICollection<Facture> facture = new Collection<Facture>();
            Facture facture1 = new Facture()
            {
                MontantFacture = totals,
            };
            _context.Facture.Add(facture1);
            facture.Add(facture1);
            var reservation = new Reservation()
            {
                ReservationDate = DateTime.Now,
                Total = totals,
                ClientName = cli,
                Facts = facture
            };
            
            _context.Add(reservation);
            _context.SaveChanges();
            
            
            return reservation;
        }

        //Assignation Client et Reservation

        public Client AssignReservation(string ClientName)
        {
            ICollection<Reservation> reserva = new Collection<Reservation>();
            var clients = _context.Client.FirstOrDefault(x => x.Name == ClientName);
            reserva.Add(_context.Reservation.FirstOrDefault(c=>c.ClientName==ClientName));
            clients.Reservations = reserva;
            _context.SaveChanges();
            return clients;
        }
        public Concerner PostReservation(DateTime checkin, DateTime checkout, int nbA, int nbC, string HotName, string chCat, string ClientName, int servSupp)
        {
            
            //catégorie
            var resprep = _context.Categories.FirstOrDefault(c => c.libelle == chCat);
            int totalDays = (checkout - checkin).Days;
            var saisons = GetSaisons(checkin,checkout);
            ICollection<Chambre> ch = new Collection<Chambre>();
            ICollection<Tarifs> tf = new Collection<Tarifs>();
            var chamb = AddChamber();
            ch.Add(chamb);
            tf.Add(GetTarifss(saisons.Libelle, chCat));
            resprep.ChambreCat = ch;
            resprep.TarifsCat = tf;
            var tarif = GetTarifss(saisons.Libelle, chCat);
            //Reservation
            var res = GetReservation(ClientName,tarif.PrixCat , nbA, nbC, servSupp, totalDays);
            var client = AssignReservation(ClientName);
            //Concerner
            Concerner cr = new Concerner()
            {
                ReservationId = res.ReservationId,
                ChamberId = chamb.ChambreId,
                Reservations = res,
                Chambres = chamb,
                NbAdultes = nbA,
                NbEnfant = nbC,
                DateErrival = checkin,
                DateDeparture = checkout

            };
            return cr;

        }
       
        //Assign client to commentaire

        public Commentaire ClientToComm (string cliName, string texte)
        {


            Commentaire com = new Commentaire()
            {
                CommentaireTexte = texte,
                ClientName=cliName,
            };
            _context.Add(com);
            _context.SaveChanges();
            return com;
        }

        //Get all the comments from client

        public List<Commentaire> getComments(string cliName)
        {
            var cli = _context.Commentaire.Where(c=>c.ClientName==cliName).ToList();
            
            
            return cli;
        }

        //Modify client data
        public bool modifyClient(string clientN, string pswdd, string num, string email)
        {
            var cli = _context.Client.FirstOrDefault(c => c.Name == clientN);
            if (cli != null)
            {
                cli.Password = pswdd;
                cli.email = email;
                cli.TelephoneNumber = num;

                _context.Update(cli);
                _context.SaveChanges();

                return true;
            }

            return false;
            
        }
    }
}
