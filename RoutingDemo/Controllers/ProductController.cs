using Microsoft.AspNetCore.Mvc;

namespace RoutingDemo.Controllers
{
    [Route("[controller]/[action]")]

    [Route("")]
    [Route("Product")]
    [Route("Product/index")]


    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Constraints

        [Route("")]
        [Route("Product")]
        [Route("Product/index")]
        [Route("Product/index/{id}/{str}")]

        public IActionResult ProductById(int id, string str)
        {
            return Content($"Blog enry with Id #{id} requested (Url Slug:{str})");
        }

        #endregion
    }
}
