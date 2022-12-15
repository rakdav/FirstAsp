using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstAsp.Models;

namespace FirstAsp.Controllers;

public class HomeController : Controller
{
    private Repository repository;
    public HomeController(PartyDbContext context)
    {
        this.repository = new Repository(context);
    }
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }
    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
        if (ModelState.IsValid)
        {
            repository.CreateGuest(guestResponse);
            return View("Thanks", guestResponse);
        }
        else
        {
            return View();
        }
    }

    public ViewResult ListResponses()
    { 
        return View(repository.Responses.Where(p => p.WillAttend == true));
    }
}
