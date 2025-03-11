using Microsoft.AspNetCore.Mvc;

namespace DemoAdmin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderStatisticController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
