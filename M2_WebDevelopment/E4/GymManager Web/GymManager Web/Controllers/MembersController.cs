using Microsoft.AspNetCore.Mvc;

namespace GymManager_Web.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
