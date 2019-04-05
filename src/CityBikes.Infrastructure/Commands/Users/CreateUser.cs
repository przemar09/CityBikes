﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Infrastructure.Commands.Users
{
    public class CreateUser : ICommand
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
