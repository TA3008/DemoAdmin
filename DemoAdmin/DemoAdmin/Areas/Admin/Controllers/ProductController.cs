using Microsoft.AspNetCore.Mvc;

namespace DemoAdmin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}