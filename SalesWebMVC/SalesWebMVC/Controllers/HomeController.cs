using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Diagnostics;

namespace SalesWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Sales System - ASP .NET in C#";
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
}
