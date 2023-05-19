using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NotifyWebApp.Data;
using NotifyWebApp.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NotifyWebApp.Controllers
{
    public class LogInController : Controller
    {
        private readonly ApplicationDBContext _db;

        private IConfiguration _configuration;

        public LogInController(ApplicationDBContext db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            User user = new User();
            return View(user);
        }

        private User Authenticate(User user)
        {
            var eflag = _db.Users.Where(entry => entry.Email == user.Email).FirstOrDefault();

            return eflag;
        }


        private string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            
            var claims = new[]
            {
               new Claim(ClaimTypes.Name, user.Name),
               new Claim(ClaimTypes.Email, user.Email)
            };

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Validate(User data)
        {
            IActionResult response = null;

            var eflag = _db.Users.Where(entry => entry.Email == data.Email).FirstOrDefault();

            if (eflag == null)
            {
                return RedirectToAction("Index");
            }

            var flag = _db.Users.Where(entry => entry.Email == data.Email && entry.Password == data.Password).FirstOrDefault();

            if (flag == null)
            {
                return RedirectToAction("Index");
            }

            User logInEr = _db.Users.Where(entry => entry.Email == data.Email).FirstOrDefault();

            if (logInEr.isAdmin)
            {
                return RedirectToAction("Index", "Admin");

            }

            var user = Authenticate(logInEr);
            
            if(user != null)
            {
                var token = GenerateToken(logInEr);
                response = RedirectToAction("Index", "User", new { id = logInEr.ID });
                return response;

            }

            ModelState.AddModelError("name","UserName Or Password Invalid");
            response = RedirectToAction("Index");
            return response;

           
            
        }
    }
}
