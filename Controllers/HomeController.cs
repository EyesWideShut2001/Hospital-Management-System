using HospitalManagment.Models;  // Make sure this is included
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore; // Ensure EF methods are available

namespace HospitalManagment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context; // Reference ApplicationDbContext here

        // Constructor where ApplicationDbContext is injected
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult MedicalStaffOverview()
        {
            var medicalStaffId = HttpContext.Session.GetInt32("MedicalStaffId");
            var medicalStaffDepartmentId = HttpContext.Session.GetInt32("MedicalStaffDepartmentId");

            if (medicalStaffId != null && medicalStaffDepartmentId != null)
            {
                // Medical staff is logged in, show only the department they belong to
                var department = _context.Departments
                    .FirstOrDefault(d => d.Id == medicalStaffDepartmentId);
        
                if (department != null)
                {
                    return View("MedicalStaffOverview", department); // Show the specific department overview
                }
        
                return RedirectToAction("DLogin", "Login"); // In case something goes wrong, redirect to login page
            }

            return RedirectToAction("DLogin", "Login"); // In case something goes wrong, redirect to login page
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Overview()
        {
            // Check for Admin login
            var adminId = HttpContext.Session.GetInt32("AdminId");
    
            if (adminId != null)
            {
                // Admin is logged in, show all departments for that admin
                var departments = _context.Departments
                    .Where(d => d.AdminId == adminId)
                    .ToList();
                return View(departments);
            }

            // Check for Medical Staff login
           
            // If neither is found, redirect to Login page
            return RedirectToAction("ALogin", "Login");
        }

    }
}