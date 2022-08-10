using Microsoft.AspNetCore.Mvc;
using PartialView.Models;
using System.Diagnostics;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           // ViewData["CurrentDataAndTime"] = DateTime.Now;

           // ViewData["MyString"] = "Hello Akash";

            ViewBag.CurrentDataAndTime = DateTime.Now;

           // TempData["CurrentDataAndTime"] = DateTime.Now;
            return View();
        }

        public IActionResult Privacy()
        {
            HttpContext.Session.SetString("SessionKeyName", "The Doctor");
            HttpContext.Session.SetInt32("SessionKeyAge", 73);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}