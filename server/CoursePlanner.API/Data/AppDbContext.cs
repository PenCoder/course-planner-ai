using CoursePlanner.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursePlanner.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Course> Courses => Set<Course>();
    }
}