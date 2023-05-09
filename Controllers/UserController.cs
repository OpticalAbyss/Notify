using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotifyWebApp.Data;
using NotifyWebApp.Models;

namespace NotifyWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _db;

        public UserController(ApplicationDBContext db)
        {
            _db = db;
        }

        [Authorize]
        public IActionResult Index(User data)
        {
            var userPlaylists = _db.Playlists.Where(playlist => playlist.User_ID == data.ID).ToList();
            return View(userPlaylists);
        }
    }
}
