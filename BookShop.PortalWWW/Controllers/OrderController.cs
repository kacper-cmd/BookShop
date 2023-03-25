using Microsoft.AspNetCore.Mvc;

namespace BookShop.PortalWWW.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
