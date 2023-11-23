using Microsoft.AspNetCore.Mvc;

namespace GirlScoutCookieBoothManager.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
