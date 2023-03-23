using Microsoft.AspNetCore.Mvc;

namespace BookShop.Intranet.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
