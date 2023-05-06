
using Microsoft.EntityFrameworkCore;
using NotifyWebApp.Models;

namespace NotifyWebApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {            
        }

        public DbSet<Album> Albums { get; set; } 
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Follower> Followers { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Play_Track> Play_Track { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
