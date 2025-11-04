using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Quiries
{
    public record GetEmployeeByIdCommand(int Employeeid):IRequest<EmployeeEntity>;


    public class GetEmployeeByIdCommandHandler(IEmployeeRepository EmpRep) : IRequestHandler<GetEmployeeByIdCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetEmployeeByIdCommand req, CancellationToken cancellationToken)
        {
            EmployeeEntity Emp = await EmpRep.GetEmployeeById(req.Employeeid);

            if (Emp != null)
            {
                return Emp;
            }

            return Emp;
        }
    }


}
