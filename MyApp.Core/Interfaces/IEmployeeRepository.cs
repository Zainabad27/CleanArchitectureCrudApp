using MyApp.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<EmployeeEntity>> GetAllEmployee();
        public Task<EmployeeEntity> GetEmployeeById(int EmployeeId);
        public Task<bool> DeleteEmployee(int EmployeeId);
        public Task<EmployeeEntity> UpdateEmployee(int EmployeeId,EmployeeEntity Employee);

        public Task<EmployeeEntity> AddEmployee(EmployeeEntity EmployeeToBeAdded);


        
    }
}
