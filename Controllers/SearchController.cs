using Microsoft.AspNetCore.Mvc;

namespace NotifyWebApp.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
