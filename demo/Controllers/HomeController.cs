using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using demo.Models;

namespace demo.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        return View("~/Views/Home/about.cshtml");
    }

 public IActionResult Service()
    {
        return View("~/Views/Home/service.cshtml");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}

// public IActionResult TestConnection()
// {
//     using (var connection = _databaseHelper.GetConnection())
//     {
//         string query = "SELECT *FROM users";
//         try
//         {
//             using (var reader = connection.ExecuteReader(query))
//             {
//                 if (reader.Read())
//                 {
//                     return View("ConnectionSuccessful");
//                 }
//                 else
//                 {
//                     return View("ConnectionError", "No data returned");
//                 }
//             }
//         }
//         catch (Exception ex)
//         {
//             return View("ConnectionError", ex.Message);
//         }
//     }
// }

// }

