using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Quiries
{
    public record GetAllEmployeesCommand():IRequest<IEnumerable<EmployeeEntity>>;
    public class GetAllEmployeesCommandHandler(IEmployeeRepository Emprep) : IRequestHandler<GetAllEmployeesCommand, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeesCommand req, CancellationToken cancellationToken)
        {
            List<EmployeeEntity> result=(await Emprep.GetAllEmployee()).ToList();

            return result;



        }
    }
}
