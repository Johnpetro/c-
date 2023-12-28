using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace demo;

public class BusinessController : Controller
{
    public IActionResult Login()
    {
        // for login
        return View("~/Views/businessView/loginView.cshtml"); // Specify the correct path to the view file
    }
    
    public IActionResult Register()
    {
        return View("~/Views/businessView/signupView.cshtml");
    }
}
