using Microsoft.AspNetCore.Mvc;

namespace DemoAdmin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HotlineController : Controller
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