﻿namespace Domain.Entities
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public required string Street { get; set; }
        public required string City { get; set; }
        public required string PostalCode { get; set; }
        public required string Country { get; set; }
    }
}
