using System.Security.Principal;

namespace HospitalManagment.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public List<User> Staff { get; set; } // Staff in this department
    }
}
