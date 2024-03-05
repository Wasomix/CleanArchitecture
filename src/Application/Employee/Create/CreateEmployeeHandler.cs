using MediatR;

namespace Application.Employee.Create
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Domain.Entities.Employee>
    {
        public async Task<Domain.Entities.Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var result = new Domain.Entities.Employee()
            {
                EmployeeId = request.employee.EmployeeId,
                Name = request.employee.Name,
                Surname = request.employee.Surname,
                Address = request.employee.Address,
                Email = request.employee.Email,
                PhoneNumber = request.employee.PhoneNumber
            };

            return await Task.FromResult(result);
        }
    }
}
