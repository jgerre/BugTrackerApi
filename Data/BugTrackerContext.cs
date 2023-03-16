using BugTrackerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTrackerApi.Data
{
    public class BugTrackerContext : DbContext
    {
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-many relationship between Bug and Comment
            modelBuilder.Entity<Bug>()
                .HasMany(b => b.Comments)
                .WithOne(c => c.Bug)
                .HasForeignKey(c => c.BugId);

            // Configure one-to-many relationship between Project and Bug
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Bugs)
                .WithOne(b => b.Project)
                .HasForeignKey(b => b.ProjectId);

            // Configure one-to-many relationship between User and Comment
            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId);


        }
    }


}
