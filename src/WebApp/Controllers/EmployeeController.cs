using Application.Employee.Create;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetEmployeeById")]
        public async Task<EmployeeDto> GetEmployeeById(int EmployeeId)
        {
            //return _mediator.Send()
            return await Task.FromResult(new EmployeeDto()
            { 
                Name = "TestName", Surname = "TestSurname", City = "TestCity", 
                Country = "TestCountry", PostalCode = "TestPC", Street = "TestStreet" 
            });
        }

        [HttpGet(Name = "GetEmployees")]
        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {

            //return _mediator.Send()
            return await Task.FromResult(new List<EmployeeDto>());
        }

        [HttpPost(Name = "CreateEmployee")]
        public async Task<EmployeeDto> CreateEmployee(EmployeeDto employeeDto)
        {
            var createEmployeeCommand = new CreateEmployeeCommand(new Employee() { 
                Name = employeeDto.Name, Surname = employeeDto.Surname, Email = employeeDto.Email, PhoneNumber = employeeDto.PhoneNumber,
                Address = new Address()
                {
                    City = employeeDto.City,
                    Country = employeeDto.Country,
                    PostalCode = employeeDto.PostalCode,
                    Street = employeeDto.Street
                }
            });

            var result = await _mediator.Send(createEmployeeCommand);

            return await Task.FromResult(new EmployeeDto()
            { 
                Name = result.Name, Surname = result.Surname, Email = result.Email, PhoneNumber = result.PhoneNumber,
                City = result.Address?.City ?? string.Empty, Country = result.Address?.Country ?? string.Empty, 
                PostalCode = result.Address?.PostalCode ?? string.Empty, Street = result.Address?.Street ?? string.Empty
            });
        }

        [HttpPut(Name = "UpdateEmployee")]
        public async Task<EmployeeDto> UpdateEmployee(EmployeeDto employee)
        {

            //return await _mediator.Send()
            return await Task.FromResult(new EmployeeDto()
            {
                Name = employee.Name,
                Surname = employee.Surname,
                City = employee.City,
                Country = employee.Country,
                PostalCode = employee.PostalCode,
                Street = employee.Street
            });
        }

        [HttpDelete(Name = "DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(Guid employeeId)
        {

            //return _mediator.Send()
            return await Task.FromResult(Ok());
        }
    }
}
