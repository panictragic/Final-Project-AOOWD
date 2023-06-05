using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.SLiddle.Models;

namespace Project.SLiddle.Controllers;

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

    public IActionResult Teams()
    {
        return View();
    }

    public IActionResult Drivers()
    {
        return View(); 
    }

    public IActionResult SS()
    {
        return View();
    }

    public IActionResult DrivetoSurvive()
    {
        return View();
    }
    public IActionResult seasonrecap()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

