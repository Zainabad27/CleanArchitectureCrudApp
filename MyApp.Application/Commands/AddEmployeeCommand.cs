using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee) : IRequest<EmployeeEntity>;


    public class AddEmployeeCommandHandler(IEmployeeRepository EmployeeRepo) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand req, CancellationToken cancellationToken)
        {
            var result=await EmployeeRepo.AddEmployee(req.Employee);

            return result;  


        }
    }
}
