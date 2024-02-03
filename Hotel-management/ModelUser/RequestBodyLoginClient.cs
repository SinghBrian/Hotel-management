using Hotel_management.Controllers;
using Hotel_management.Models;
namespace Hotel_management.ModelUser
{
    public class RequestBodyLoginClient
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string TelephoneNumber { get; set; }
        public string email { get; set; }

        public string? Token { get;set; }
        public static Client Map(RequestBodyLoginClient cs)
        {
            return new Client()
            {
                Name = cs.Name,
            };
        }
    }
}
