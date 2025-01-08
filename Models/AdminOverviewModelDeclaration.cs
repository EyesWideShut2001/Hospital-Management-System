namespace HospitalManagment.Models;

public class AdminOverviewModelDeclaration
{
    public int AdminId {get; set;}
    public IEnumerable<Department> Departments { get; set; }
    public IEnumerable<MedicalStaff> MedicalStaffList { get; set; }
}
