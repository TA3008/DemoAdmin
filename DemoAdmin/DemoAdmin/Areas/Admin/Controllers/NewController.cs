using Microsoft.AspNetCore.Mvc;

namespace DemoAdmin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(Guid? id)
        {
            return View();
        }
    }
}
