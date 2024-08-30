using System.Security.Principal;

namespace HospitalManagment.Models
{
    public class Admin
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
    }
}
