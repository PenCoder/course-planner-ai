using CoursePlanner.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursePlanner.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Plan> Plans => Set<Plan>();
        public DbSet<PlanEntry> PlanEntries => Set<PlanEntry>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the primary key for the PlanEntry entity
            modelBuilder.Entity<PlanEntry>()
                .HasKey(pe => new { pe.PlanEntryId, pe.PlanId, pe.CourseId });

            // Configure the relationships
            modelBuilder.Entity<PlanEntry>()
                .HasOne(pe => pe.Plan)
                .WithMany(p => p.PlanEntries)
                .HasForeignKey(pe => pe.PlanId);

            modelBuilder.Entity<PlanEntry>()
                .HasOne(pe => pe.Course)
                .WithMany()
                .HasForeignKey(pe => pe.CourseId);
        }
    }
}