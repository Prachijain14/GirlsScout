using Microsoft.AspNetCore.Mvc;

namespace GirlScoutCookieBoothManager.Web.Controllers
{
    public class LotteryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
