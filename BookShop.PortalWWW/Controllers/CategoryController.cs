using Microsoft.AspNetCore.Mvc;

namespace BookShop.PortalWWW.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
