using Microsoft.AspNetCore.Mvc;
using NotifyWebApp.Data;
using NotifyWebApp.Models;

namespace NotifyWebApp.Controllers
{
    public class LogInController : Controller
    {
        private readonly ApplicationDBContext _db;

        public LogInController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Validate(User data)
        {
            var eflag = _db.Users.Where(entry => entry.Email == data.Email).FirstOrDefault();

            if (eflag == null)
            {
                return RedirectToAction("Index");
            }

            var flag = _db.Users.Where(entry => entry.Email == data.Email && entry.Password == data.Password).FirstOrDefault();

            if(flag == null)
            { 
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "Home" , data/*data*/);
        }
    }
}
