
using Microsoft.EntityFrameworkCore;
using NotifyWebApp.Models;

namespace NotifyWebApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {            
        }

        public DbSet<User> Users { get; set; }

    }
}
