using Microsoft.EntityFrameworkCore;
using MtApp.Entities;

namespace MtApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
