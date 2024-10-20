using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers;

public class CalculatorController : Controller
{

    [HttpPost]
    public IActionResult Result([FromForm] CalculatorModel model)
    {
        if (!model.IsValid())
        {
            return View("Error");
        }
        return View(model);
    }

    public IActionResult Form() {
        return View();
    } 
    
}