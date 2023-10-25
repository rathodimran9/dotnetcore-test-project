using Microsoft.EntityFrameworkCore;
using PragimTechDotNetCore_Practice.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PragimTechDotNetCore_Practice.DBContext
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ModelSeedData();
        }
    }
}
