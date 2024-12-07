namespace HospitalManagment.Models
{
    public class MedicalStaff
    {
        public int Id { get; set; }
        
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Hashed password
        public int DepartmentId { get; set; } // Foreign key
        //public Department Department { get; set; } // Navigation property
    }
}
