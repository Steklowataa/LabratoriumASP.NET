using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebbApp.Models;

namespace WebbApp.Controllers;

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

    public IActionResult About() {
        return View();
    }

     [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int numberX, int numberY, string operation)
        {
            int result = 0;

            switch (operation)
            {
                case "add":
                    result = numberX + numberY;
                    break;
                case "subtract":
                    result = numberX - numberY;
                    break;
                case "multiply":
                    result = numberX * numberY;
                    break;
                case "divide":
                    if (numberY != 0)
                    {
                        result = numberX / numberY;
                    }
                    else
                    {
                        ViewBag.Error = "Cannot divide by zero.";
                        return View();
                    }
                    break;
                default:
                    ViewBag.Error = "Invalid operation.";
                    return View();
            }

            ViewBag.Result = result;
            return View("Result");
        }

    [HttpGet]
    public IActionResult Age() {
        return View();
    }

    [HttpPost]
    public IActionResult Age(string userDate) {
        DateTime birthday;

        if(DateTime.TryParse(userDate, out birthday)) {
            DateTime today = DateTime.Now;
            TimeSpan age = today - birthday;

            int years = (int)(age.TotalDays / 365.25);
            int month = (int)((age.TotalDays % 365.25) / 30.44);
            int day = (int)(age.TotalDays % 30.44);
            int hours = age.Hours;
            int minutes = age.Minutes;
            ViewBag.Result = $"Ty masz {years} lat,{month} miesiacy, {day} dni, {hours} godzin i {minutes} minut";
            return View("ResultAge");
        }
       else {
        ViewBag.Error = "Nieprawidlowy format dannych";
        return View("AgeError");
       }
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
