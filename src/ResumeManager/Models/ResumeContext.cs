using ResumeManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ResumeManager.Models
{
    public class ResumeContext : DbContext
    {
        public DbSet<User> Users { get; set; }




        public ResumeContext(DbContextOptions<ResumeContext> options)
        : base(options)
        {
        }
    }
}