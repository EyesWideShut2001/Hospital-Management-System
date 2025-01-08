using Hospital_Managment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Managment.Controllers;

public class OverviewController : Controller
{
    private readonly DepartmentService _departmentService;
    
    public OverviewController(DepartmentService departmentService)
    { 
        _departmentService = departmentService;
    }
    
    public IActionResult GetDepartmentsByAdminId(int adminId)
    {
        var departments = _departmentService.GetAllDepartmentsAdminId(adminId);
        return PartialView("DepartmentsView", departments);
    }
    
    public IActionResult GetAllmedicalStaffByAdminId(int adminId)
    {
        var medicalStaff = _departmentService.GetAllMedicalStaffAdminId(adminId);
        return PartialView("MedicalStaffView", medicalStaff);
    }
    
    public IActionResult GetAllPatientsByAdminId(int adminId)
    {
        var patients = _departmentService.GetAllPatientsAdminId(adminId);
        return PartialView("PatientsView", patients);
    }
}