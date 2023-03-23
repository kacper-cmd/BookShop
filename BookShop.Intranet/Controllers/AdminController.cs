using Microsoft.AspNetCore.Mvc;

namespace BookShop.Intranet.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
