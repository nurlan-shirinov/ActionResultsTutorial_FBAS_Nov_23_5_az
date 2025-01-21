using ActionResultsTutorial.Entities;
using Microsoft.EntityFrameworkCore;

namespace ActionResultsTutorial.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
