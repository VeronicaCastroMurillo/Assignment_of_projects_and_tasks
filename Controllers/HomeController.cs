using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment_of_projects_and_tasks.Models;

namespace Assignment_of_projects_and_tasks.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }

    public IActionResult Users()
    {
        return View();
    }

    public IActionResult Tasks()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
