using crud_web_api_repository_pattern.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_web_api_repository_pattern.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
