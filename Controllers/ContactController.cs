using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab3.Models;
using lab3.Services;

namespace lab3.Controllers;

// public class ContactController : Controller
// {

//    private readonly IContactService _contactService;

//    public ContactController(IContactService contactService) {
//     _contactService = contactService;
//    }
//     //Lista kontaktów
//     public IActionResult Index() {
//         var contacts = _contactService.GetAll();
//         var contactDictionary = contacts.ToDictionary(c => c.Id);
//         return View(contactDictionary);
//     }


//     //formularz
//     [HttpGet]
//     public IActionResult Add() {
//         return View();
//     }

//     [HttpPost]
//     public IActionResult Add(ContactModel model) {
//         if (!ModelState.IsValid) {
//             return View();
//         }
//         _contactService.Add(model);
//         return RedirectToAction("Index");
//     }
    
//     [HttpGet]
//     public IActionResult Delete(int id) {
//         var contact = _contactService.GetById(id);
//         if (contact != null) {
//             return View(contact);
//         } else {
//             return NotFound();
//         }
//     }

//     [HttpPost]
//     public IActionResult DeleteConfirmed(int id) {
//         _contactService.Delete(id);
//         return RedirectToAction("Index");
//     }

//     [HttpGet]
//     public IActionResult Details(int id) {
//         var contact = _contactService.GetById(id);
//         if (contact != null) {
//             return View(contact);
//         } else {
//             return NotFound();
//         }
//     }

//     [HttpPost]
//     public IActionResult Details(int id) {
//         var contact= _contactService.GetById(id);
//             if(contact != null) {
//                 return View(contact);
//             } else {
//                 return NotFound();
//         }
//     }


//     [HttpGet]
//     public IActionResult Edit(int id) {
//         var contact = _contactService.GetById(id);
//         if (contact != null) {
//             return View(contact);
//         } else {
//             return NotFound();
//         }
//     }

//     [HttpPost]
//    public IActionResult Edit(ContactModel model) {
//     if (ModelState.IsValid) {
//         _contactService.Update(model);
//         return RedirectToAction("Index");
//     }
//     return View(model);
// }


// }
public class ContactController : Controller
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    // Lista kontaktów
    public IActionResult Index()
    {
        var contacts = _contactService.GetAll();
        var contactDictionary = contacts.ToDictionary(c => c.Id);
        return View(contactDictionary);
    }

    // Formularz
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        _contactService.Add(model);
        return RedirectToAction("Index");
    }

    // Delete (GET - Show Confirmation)
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var contact = _contactService.GetById(id);
        if (contact != null)
        {
            return View(contact);
        }
        else
        {
            return NotFound();
        }
    }

    // Delete (POST - Perform Deletion)
    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        _contactService.Delete(id);
        return RedirectToAction("Index");
    }

    // Details
    [HttpGet]
    public IActionResult Details(int id)
    {
        var contact = _contactService.GetById(id);
        if (contact != null)
        {
            return View(contact);
        }
        else
        {
            return NotFound();
        }
    }

    // Edit (GET - Show Edit Form)
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var contact = _contactService.GetById(id);
        if (contact != null)
        {
            return View(contact);
        }
        else
        {
            return NotFound();
        }
    }

    // Edit (POST - Save Changes)
    [HttpPost]
    public IActionResult Edit(ContactModel model)
    {
        if (ModelState.IsValid)
        {
            _contactService.Update(model);
            return RedirectToAction("Index");
        }
        return View(model);
    }
}
