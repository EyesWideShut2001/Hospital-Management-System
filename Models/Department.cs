namespace HospitalManagment.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    
        // Foreign key
        public int AdminId { get; set; }

        // Navigation property for the Admin managing this department
        public Admin Admin { get; set; } 
        
        public string? Location { get; set; } // e.g., City or Building Location
        public DateTime? FoundedDate { get; set; } // Date department was founded
        public string? MainDoctor { get; set; } // Name of the main doctor
        public string? Description { get; set; } // A detailed description
        public string? Accreditations { get; set; } // Accreditations list (could be CSV or multi-line text)
        
        // Navigation properties for one-to-many relationships
        public ICollection<MedicalStaff> MedicalStaffs { get; set; } // Medical Staff working in this department
        public ICollection<Patient> Patients { get; set; } // Patients assigned to this department
    }
}