using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NotifyWebApp.Data;
using NotifyWebApp.Models;
using System.Xml.Linq;

namespace NotifyWebApp.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ApplicationDBContext _db;

        public SignUpController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(User data)
        { 
            if (_db.Users.Where(x => x.Name == data.Name).FirstOrDefault() != null)
            {
                ModelState.AddModelError("name", "Name Already Exists, Choose a Different Name");
            }
            if (_db.Users.Where(x => x.Email == data.Email).FirstOrDefault() != null)
            {
                ModelState.AddModelError("email", "Account with this Email already exists");
            }

            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            _db.Users.Add(data);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home") ;
        }

    }
}
