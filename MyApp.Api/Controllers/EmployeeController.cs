using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Commands;
using MyApp.Application.Quiries;
using MyApp.Core.Entities;

namespace MyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender Sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity Employee)
        {

            var res = await Sender.Send(new AddEmployeeCommand(Employee));
            return Ok(res);

        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllEmployeesAsync()
        {

            var res = await Sender.Send(new GetAllEmployeesCommand());
            return Ok(res);

        }
        [HttpGet("${id}")]
        public async Task<IActionResult> GetEmployeeByIdAsync(int id) {

            var res=await Sender.Send(new GetEmployeeByIdCommand(id));
            return Ok(res);
        
        }
    }
}
