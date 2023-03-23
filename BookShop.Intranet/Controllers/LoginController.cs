using Microsoft.AspNetCore.Mvc;

namespace BookShop.Intranet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
