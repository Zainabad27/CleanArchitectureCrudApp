using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;

namespace MyApp.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> Options):DbContext(Options)
    {
        public DbSet<EmployeeEntity> Employees { get; set; }

    }
}
