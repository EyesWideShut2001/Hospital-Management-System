using Microsoft.AspNetCore.Identity;

namespace HospitalManagment.Models
{
    public class User : IdentityUser
    {
        // You can remove the `Username` property because `IdentityUser` already includes `UserName`.
        // public string Username { get; set; } 

        public string Role { get; set; } // Admin, DepartmentHead, MedicalStaff

        // Foreign key to Department
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
