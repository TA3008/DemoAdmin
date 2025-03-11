using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DemoAdmin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
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
