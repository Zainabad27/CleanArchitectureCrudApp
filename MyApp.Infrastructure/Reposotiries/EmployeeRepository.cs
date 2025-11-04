using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Reposotiries
{
    public class EmployeeRepository(AppDbContext context) : IEmployeeRepository
    {
        public async Task<EmployeeEntity> AddEmployee(EmployeeEntity EmployeeToBeAdded)
        {
            await context.Employees.AddAsync(EmployeeToBeAdded);
            await context.SaveChangesAsync();   
            return EmployeeToBeAdded;
        }

        public async Task<bool> DeleteEmployee(int EmployeeId)
        {
            EmployeeEntity Emp=await context.Employees.FirstOrDefaultAsync(e=>e.Id==EmployeeId);
            if (Emp != null) {
                context.Employees.Remove(Emp);
                return true;
            
            }

            return false;
            
        }

        public async Task<IEnumerable<EmployeeEntity>> GetAllEmployee()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeById(int EmployeeId)
        {
           return await context.Employees.FirstOrDefaultAsync(e => e.Id == EmployeeId);
           
        }

        public async Task<EmployeeEntity> UpdateEmployee(int EmployeeId, EmployeeEntity Employee)
        {
            EmployeeEntity Emp=await context.Employees.FirstOrDefaultAsync(e => e.Id == EmployeeId);
            if (Emp != null) {
                Emp = Employee;
                await context.SaveChangesAsync();
                return Employee;
            
            }
            return null;
        }

       
    }
}
