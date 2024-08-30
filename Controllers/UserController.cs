using Microsoft.AspNetCore.Mvc;

namespace HospitalManagment.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
