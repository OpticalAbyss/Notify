using Microsoft.AspNetCore.Mvc;

namespace NotifyWebApp.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
