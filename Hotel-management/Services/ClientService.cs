

using Hotel_management.Interfaces;
using Hotel_management.Models;
using Hotel_management.ModelUser;
using Microsoft.EntityFrameworkCore;

namespace Hotel_management.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepo _ClientRepos;

        public ClientService(IClientRepo clientRepo)
        {
            _ClientRepos = clientRepo;
        }

        public  List<Hotels> Gethotels (RequestBodyCriteria crit)
        {
            var hot = _ClientRepos.GetHotelByCriteria (crit);
            return hot;
        }

        public bool GetClientLogin(RequestBodyLoginClient cs)
        {
            var clog =_ClientRepos.GetClientLogin (cs);
            if (clog == true)
            {
                return true;
            }
            return false;
        }

        public bool PostNewClientLogin(RequestBodyLoginClient cs)
        {
            var cl = _ClientRepos.PostNewClientLogin(cs);

            if (cl == true) 
            { 
                return true;
            }
            return false;
        }

        public Concerner PostReservation(DateTime checkin, DateTime checkout, int nbA, int nbC, string HotName, string chCat, string ClientName, int servSupp)
        {

            var res = _ClientRepos.PostReservation(checkin,checkout,nbA,nbC,HotName, chCat, ClientName, servSupp);
            return res;
        }

        public List<Reservation> GetFullReservation(string cliN)
        {
            return _ClientRepos.GetFullReservation(cliN);
        }


        public Commentaire ClientToComm(string cliName, string texte)
        {
            return _ClientRepos.ClientToComm(cliName, texte);
            
            
        }

        public List<Commentaire> getComments(string cliName)
        {
            return _ClientRepos.getComments(cliName);
        }

        public bool modifyClient(string clientN, string pswdd, string num, string email)
        {
            return _ClientRepos.modifyClient(clientN, pswdd, num, email);
        }

        public bool CheckClientName(string name)
        {
            return _ClientRepos.CheckClientName(name);
        }
    }
}
