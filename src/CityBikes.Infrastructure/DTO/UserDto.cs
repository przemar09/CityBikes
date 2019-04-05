using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Infrastructure.DTO
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public AddressDto Address { get; set; }
    }
}
