using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortaalBackend.Domain.Configuration;
using PortaalBackend.Domain.Models;
using PortaalBackend.Domain.Models.Joins;

namespace PortaalBackend.Business.Infrastructure
{
    public class DataContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<User> User { get; set; }

        //Join Tables
        public DbSet<AssignmentTag> AssignmentTags { get; set; }


        public DataContext()
        {

        }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PortalDB;User Id=sa;Password=Pass@word;Trust Server Certificate=true;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().OwnsOne(a => a.Ratings);
            modelBuilder.ApplyConfiguration(new AssignmentTagConfiguration());

            modelBuilder = Seeding(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private static ModelBuilder Seeding(ModelBuilder modelBuilder)
        {
            User john = new() { CreatedById = -2, Email = "john.smith@gmail.com", FirstName = "John", LastName = "Smith", Id = 1 };
            User jane = new() { CreatedById = -2, Email = "jane.smith@gmail.com", FirstName = "Jane", LastName = "Smith", Id = 2 };
            modelBuilder.Entity<User>().HasData(john, jane);

            return modelBuilder;
        }
    }
}
