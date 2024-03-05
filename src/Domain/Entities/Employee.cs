namespace Domain.Entities
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Address? Address { get; set; }
    }
}
