using Microsoft.AspNetCore.Mvc;

namespace GymManager_Web.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult MemberIn()
        {
            return View();
        }
        public IActionResult MemberOut()
        {
            return View();
        }
    }
}
