namespace Domain.Entities
{
    public class Employee
    {
        /// <summary>
        /// EmployeeId is going to be the identity number without letters
        /// </summary>
        public int EmployeeId { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Address? Address { get; set; }
    }
}
