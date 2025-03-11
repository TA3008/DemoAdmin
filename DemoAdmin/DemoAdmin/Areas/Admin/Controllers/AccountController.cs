using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DemoAdmin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        public ActionResult Users()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> AssignRoles()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UserDetails()
        {
            return View();
        }
    }
}
