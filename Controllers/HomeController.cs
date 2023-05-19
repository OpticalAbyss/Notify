using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotifyWebApp.Data;
using NotifyWebApp.Models;
using System.Diagnostics;

namespace NotifyWebApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _db;

        public HomeController(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Playlist>>> GetPlaylists()
        {
            return await _db.Playlists
                .Select(x => new Playlist()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Description = x.Description,
                    User_ID = x.User_ID,
                    Image = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.Image)
                })
                .ToListAsync();
        }


        public IActionResult Index()
        {
            IEnumerable<Playlist> PlayLists = _db.Playlists
                .Select(x => new Playlist()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Description = x.Description,
                    User_ID = x.User_ID,
                    Image = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.Image)
                })
                .ToList(); ;


            return View(PlayLists);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cookies()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}