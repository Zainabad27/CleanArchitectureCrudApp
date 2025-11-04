using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Reposotiries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service)
        {
            service.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=.;Database=Zatabase;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
            });
            service.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return service;
        }

    }
}
