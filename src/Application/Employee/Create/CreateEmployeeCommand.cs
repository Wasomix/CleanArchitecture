using MediatR;

namespace Application.Employee.Create
{
    public record CreateEmployeeCommand(Domain.Entities.Employee employee) : IRequest<Domain.Entities.Employee>;
}
