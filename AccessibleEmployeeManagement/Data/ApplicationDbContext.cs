using AccessibleEmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace AccessibleEmployeeManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } = null!;
    }
}