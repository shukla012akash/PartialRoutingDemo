using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;
using System.Diagnostics;

namespace RoutingDemo.Controllers
{
    [Route("[controller]/[action]")]
    [Route("")]
    [Route("Home")]
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

        #region Constraints

        [Route("")]
        [Route("Home")]
        [Route("Home/index")]
        [Route("Home/index/{id}/{str}")]

        public IActionResult ProductById(int id, string str)
        {
            return Content($"Blog enry with Id #{id} requested (Url Slug:{str})");
        }

        #endregion

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