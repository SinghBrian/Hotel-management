using Hotel_management.Models;
using Hotel_management.ModelUser;

namespace Hotel_management.Interfaces
{
    public interface IClientService
    {
        public List<Hotels> Gethotels(RequestBodyCriteria crit);

        public bool GetClientLogin(RequestBodyLoginClient cs);

        public bool PostNewClientLogin(RequestBodyLoginClient cs);

        public Concerner PostReservation(DateTime checkin, DateTime checkout, int nbA, int nbC, string HotName, string chCat, string ClientName, int servSupp);

        public List<Reservation> GetFullReservation(string clientName);

        public Commentaire ClientToComm(string cliName, string texte);

        public List<Commentaire> getComments(string cliName);

        public bool modifyClient(string clientN, string pswdd, string num, string email);

        public bool CheckClientName(string name);

    }
}
