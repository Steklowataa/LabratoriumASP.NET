using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Birth.Models;

namespace Birth.Controllers;

public class Birth : Controller
{

    [HttpPost]
    public IActionResult Result(BirthModel model)
{
    return View(model);
}


    public IActionResult Form() {
        return View();
    }
    
}