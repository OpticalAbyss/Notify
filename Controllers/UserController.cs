using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotifyWebApp.Data;
using NotifyWebApp.Models;
using System.Security.Claims;

namespace NotifyWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _db;

        private User currentUser = null;

        public UserController(ApplicationDBContext db)
        {
            _db = db;
        }

        private void InititalizeUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if(identity != null) 
            {
                var claims = identity.Claims;

                var sss = claims.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value;
                var currentUser = _db.Users.Where(entry => entry.Email == claims.FirstOrDefault(o => o.Type == ClaimTypes.Email).Value).FirstOrDefault();
            }
        }

        [Route("Home")]
        //[Authorize]
        [HttpGet("Home")]
        public async Task<IActionResult> Index(int ID)
        {
            if(currentUser == null)
            {
                currentUser = _db.Users.Where(e => e.ID == ID).FirstOrDefault();
            }

            //var userPlaylists = _db.Playlists.Where(playlist => playlist.User_ID == currentUser.ID).ToList();
            return currentUser == null ? RedirectToAction("Index", "Login") : View(new Tuple<IEnumerable<Playlist>, User>(await _db.Playlists
                .Select(x => new Playlist()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Description = x.Description,
                    User_ID = x.User_ID,
                    Image = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.Image)
                })
                .ToListAsync(), currentUser));
        }
    }
}
