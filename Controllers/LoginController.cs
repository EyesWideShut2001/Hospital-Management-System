using HospitalManagment.Models;
using Hospital_Managment.Services;
using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly LoginService _loginService;

    public LoginController(ApplicationDbContext context, LoginService loginService)
    {
        _context = context;
        _loginService = loginService;
    }

   public IActionResult ALogin()
   { return View();
   }
   public IActionResult DLogin()
   { return View();
   }
    [HttpPost]
    public IActionResult ALogin(string Username, string Password)
    {
        try
        {
            var admin = _loginService.LoginCheck(Username, Password);

            if (admin != null)
            {
                // Store admin's ID in session
                HttpContext.Session.SetInt32("AdminId", admin.Id);

                // Redirect to overview
                return RedirectToAction("Overview", "Home");
            }

            ViewBag.ErrorMessage = "Username or password is incorrect. Please try again.";
            return ALogin();
        }
        catch (Exception ex)
        {
            ViewBag.ErrorMessage = "An unexpected error occurred. Please try again.";
            return ALogin();
        }
    }

    [HttpPost]
    public IActionResult DLogin(string Username, string Password)
    {
        try
        {
            var medicalStaff = _loginService.LoginCheckForMedicalStaff(Username, Password);

            if (medicalStaff != null)
            {
                // Store medical staff's ID and DepartmentId in session
                HttpContext.Session.SetInt32("MedicalStaffId", medicalStaff.Id);
                HttpContext.Session.SetInt32("MedicalStaffDepartmentId", medicalStaff.DepartmentId);

                // Redirect to department overview or specific department data
                return RedirectToAction("MedicalStaffOverview", "Home");
            }

            ViewBag.ErrorMessage = "Username or password is incorrect. Please try again.";
            return DLogin();
        }
        catch (Exception ex)
        {
            ViewBag.ErrorMessage = "An unexpected error occurred. Please try again.";
            return DLogin();
        }
    }
}
