using Hotel_management.Models;
using System.Diagnostics.Metrics;

namespace Hotel_management.ModelUser
{
    public class RequestBodyCriteria
    {
        public string Criteria_stars { get; set; }
        public string Criteria_size { get; set; }

        public string destination { get; set; }

        public static Hotels Map(RequestBodyCriteria crit)
        {
            return new Hotels()
            {
                destination = crit.destination,
            };
        }
    }
}
