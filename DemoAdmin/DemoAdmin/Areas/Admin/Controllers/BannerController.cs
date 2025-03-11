using Microsoft.AspNetCore.Mvc;

namespace DemoAdmin.Areas.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller { 

        public async Task<ActionResult> Index()
        {
            return View();
        }

        public async Task<ActionResult> Preview()
        {
            return View();
        }

        public async Task<ActionResult> Edit()
        {
            return View();
        }

    }
}
