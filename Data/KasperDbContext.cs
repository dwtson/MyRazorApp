using Microsoft.EntityFrameworkCore;
using MyRazorApp.Models;

namespace MyRazorApp.Data
{
    public class KasperDbContext : DbContext
    {
        public KasperDbContext(DbContextOptions<KasperDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
