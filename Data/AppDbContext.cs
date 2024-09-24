using Microsoft.EntityFrameworkCore;
using webcruddotnetcore.Models;

namespace webcruddotnetcore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map Employee class to tblemp table
            modelBuilder.Entity<Employee>().ToTable("tblemp");
        }
    }
}
