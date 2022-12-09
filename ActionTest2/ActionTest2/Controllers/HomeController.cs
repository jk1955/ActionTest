using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ActionTest2.Models;
using Microsoft.AspNetCore.Http.Extensions;
using System.Xml.Linq;

namespace ActionTest2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int id, string name)
    {

        string tmp = Request.GetDisplayUrl();

        if (TempData["fromPerson"] as string != "true")
        {
            TempData["url"] = tmp;

            TempData["id"] = id;

            TempData["name"] = name;
        }

        //Response.WriteAsJsonAsync("URL: " + tmp);

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

