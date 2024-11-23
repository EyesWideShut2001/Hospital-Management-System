using System.Security.Principal;

namespace HospitalManagment.Models

{
    public class Admin
    {
        public int Id { get; set; } // Primary key
        public string Username { get; set; } // Admin's username
        public string PasswordHash { get; set; } // Hashed password
        public string Email { get; set; } // Admin's email
                                          // Additional personal details can be added here
    }
}
