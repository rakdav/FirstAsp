using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstAsp.Models;

namespace FirstAsp.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}

    //public IActionResult Index()
    //{
    //    return View();
    //}

    //public IActionResult Privacy()
    //{
    //    return View();
    //}

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
    //public ViewResult Index()
    //{
    //    int hour=DateTime.Now.Hour;
    //    string viewModel = hour < 12 ? "Доброе утро" : "Добрый день";
    //    return View("MyView",viewModel);
    //}
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
        Repository.AddResponse(guestResponse);
        return View("Thanks",guestResponse);
    }

    public ViewResult ListResponses()
    {
        return View(Repository.Responses.Where(p => p.WillAttend == true));
    }
}
