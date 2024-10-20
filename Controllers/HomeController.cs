using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
        // [HttpPost]
        // public IActionResult Add(int numberX, int numberY, string operation)
        // {
        //     int result = 0;

        //     switch (operation)
        //     {
        //         case "add":
        //             result = numberX + numberY;
        //             break;
        //         case "subtract":
        //             result = numberX - numberY;
        //             break;
        //         case "multiply":
        //             result = numberX * numberY;
        //             break;
        //         case "divide":
        //             if (numberY != 0)
        //             {
        //                 result = numberX / numberY;
        //             }
        //             else
        //             {
        //                 ViewBag.Error = "Cannot divide by zero.";
        //                 return View();
        //             }
        //             break;
        //         default:
        //             ViewBag.Error = "Invalid operation.";
        //             return View();
        //     }

        //     ViewBag.Result = result;
        //     return View("Result");
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
