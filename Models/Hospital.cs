using HospitalManagment.Models;

public class Hospital
{
    public int Id { get; set; } // Primary key
    public string Name { get; set; } // Name of the hospital
    public string HospitalCode { get; set; } // Randomly generated code
    public Admin Admin { get; set; } // Navigation property to Admin
}
