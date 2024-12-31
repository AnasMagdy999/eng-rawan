using Microsoft.EntityFrameworkCore;

namespace AnasMagdy.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<TASKK> Tasks { get; set; }
        public DbSet<TeamMember> teamMembers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasMany<TASKK>().WithOne(x => x.Project).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<TeamMember>().HasMany<TASKK>().WithOne(x => x.TeamMember).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
