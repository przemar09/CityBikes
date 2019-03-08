using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Infrastructure.DTO
{
    public class AddressDto
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public int Apartment { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
