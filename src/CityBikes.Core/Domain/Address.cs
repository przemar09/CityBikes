using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    public class Address
    {
        public Guid Id { get; protected set; }
        public string Street { get; protected set; }
        public string StreetNumber { get; protected set; }
        public string PostalCode { get; protected set; }
        public string City { get; protected set; }
        public string Country { get; protected set; }

        protected Address()
        {

        }

        public Address(string street, string streetNumber, string postalCode, string city, string country)
        {
            Id = Guid.NewGuid();
            Street = street;
            StreetNumber = streetNumber;
            PostalCode = postalCode;
            City = city;
            Country = country;
        }

        // Add validation
    }
}
