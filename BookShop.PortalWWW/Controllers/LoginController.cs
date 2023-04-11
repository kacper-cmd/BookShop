using Microsoft.AspNetCore.Mvc;

namespace BookShop.PortalWWW.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
