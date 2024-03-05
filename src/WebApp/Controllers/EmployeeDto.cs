namespace WebApp.Controllers
{
    public class EmployeeDto
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public required string Street { get; set; }
        public required string City { get; set; }
        public required string PostalCode { get; set; }
        public required string Country { get; set; }
    }
}
