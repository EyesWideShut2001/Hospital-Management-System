using Hospital_Managment.Models;
using System.Numerics;

namespace HospitalManagment.Models
{
    public class Patient
    {
        public int Id { get; set; } // Use PascalCase for properties
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MedicalRecord { get; set; }

        public int DepartmentId { get; set; } // Foreign key for Department
        public Department Department { get; set; } // Navigation property for Department

        public int AssignedDoctorId { get; set; } // Foreign key for Doctor
        public MedicalStaff AssignedDoctor { get; set; } // Navigation property for Doctor
    }
}
