using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using HospitalManagment.Models;

namespace HospitalManagement.Controllers
{
   // [Authorize(Policy = "AdminPolicy")]
    public class AdminController : Controller
    {
        // Actions for managing departments, staff, etc.
        
        public IActionResult AdminLogin()
        {
            return View();
        }

        public IActionResult LoginAdminPls()
        {
            return View();
        }
        
    }
}
