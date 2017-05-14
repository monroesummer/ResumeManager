using ResumeManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ResumeManager.Models
{
    public class ResumeContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Competitor> Competitors { get; set; }


        public ResumeContext(DbContextOptions<ResumeContext> options)
        : base(options)
        {
        }
    }
}