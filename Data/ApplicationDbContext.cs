using BulkyAppRazor.Model;
using Microsoft.EntityFrameworkCore;

namespace BulkyAppRazor.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Action", Address = "Jamshedpur" },
            new Employee { Id = 2, Name = "SciFi", Address = "Kolkata" },
            new Employee { Id = 3, Name = "History", Address = "Pune" });
        }

    }
}
