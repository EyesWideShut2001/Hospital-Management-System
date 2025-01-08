using Microsoft.AspNetCore.Mvc;
using HospitalManagment.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace HospitalManagement.Controllers
{
    public class MedicalStaffController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public MedicalStaffController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // View for Medical Staff Overview for the logged-in Admin
        public IActionResult ViewMedicalStaff(string searchQuery)
        {
            // Get the currently logged-in admin
            var adminIdString = _userManager.GetUserId(User); // Get the logged-in user Id (string)
            
            // Convert the adminId to an integer
            int adminId = 0;
            if (int.TryParse(adminIdString, out adminId))
            {
                // Query the medical staff for the logged-in admin
                var medicalStaffList = _context.MedicalStaffs
                    .Where(ms => ms.AdminId == adminId && 
                                 (string.IsNullOrEmpty(searchQuery) || ms.Username.Contains(searchQuery)))
                    .ToList();

                return View(medicalStaffList);
            }

            // In case of failure to parse, return an empty list or handle the error
            return View(new List<MedicalStaff>());
        }

        // Partial view to get medical staff based on department id
       
        public IActionResult MedicalStaffList(string searchQuery)
        {
            var adminIdString = _userManager.GetUserId(User);
            int adminId = 0;
            if (int.TryParse(adminIdString, out adminId))
            {
                var medicalStaffList = _context.MedicalStaffs
                    .Where(ms => ms.AdminId == adminId)
                    .ToList();

                // Return the partial view from the Shared folder
                return PartialView("~/Views/Shared/_MedicalStaffListPartial.cshtml", medicalStaffList);
            }
            return PartialView("~/Views/Shared/_MedicalStaffListPartial.cshtml", new List<MedicalStaff>());
        }


    }
}