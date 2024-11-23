using Hospital_Managment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Managment.Controllers;

public class LoginController : Controller
{
    
    private readonly LoginService _loginService;

    public LoginController(LoginService loginService)
    {
        _loginService = loginService;
    }
    
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string Username, string Password)
    {
        // var admin = _loginService.LoginCheck(Username, Password);

        try
        {
            var admin = _loginService.LoginCheck(Username, Password);
            return RedirectToAction("Index", "Home");
        }
        catch (Exception e)
        {
            return RedirectToAction("Error", "Home");
        }
        
    }
}