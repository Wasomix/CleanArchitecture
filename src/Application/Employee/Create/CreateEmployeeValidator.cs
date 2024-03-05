using FluentValidation;

namespace Application.Employee.Create
{
    public class CreateEmployeeValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeValidator() 
        { 
            RuleFor(command => command.employee.Name).NotEmpty();
            RuleFor(command => command.employee.Surname).NotEmpty();
        }
    }
}
