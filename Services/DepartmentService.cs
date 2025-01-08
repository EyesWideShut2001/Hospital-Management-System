using HospitalManagment.Models;

namespace Hospital_Managment.Services;

public class DepartmentService
{
    private readonly ApplicationDbContext _context;

    public DepartmentService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Department> GetAllDepartmentsAdminId(int adminId)
    {
        return _context.Departments
            .Where(d => d.AdminId == adminId)
            .ToList();
    }

    public List<MedicalStaff> GetAllMedicalStaffAdminId(int adminId)
    {
        return _context.MedicalStaffs
            .Where(d => d.AdminId == adminId)
            .ToList();
    }
    
    public List<Patient> GetAllPatientsAdminId(int adminId)
    {
        var medicalStaffIds = GetAllMedicalStaffAdminId(adminId)
            .Select(ms => ms.Id);
        
        return _context.Patients
            .Where(p => medicalStaffIds.Contains(p.Id))
            .ToList();
    }
    
}