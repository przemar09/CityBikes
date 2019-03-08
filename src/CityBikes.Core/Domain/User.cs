using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public Address Address { get; protected set; }
        public Account Account { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public bool IsActive { get; protected set; }

        // Not sure if User should have Bike
        public Bike Bike { get; protected set; }


        protected User()
        {

        }

        // Not sure if address and account should be passed by constructor
        public User(string name, string lastName, string email, string password, string salt, Address address, Account account)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            Email = email.ToLowerInvariant();
            Password = password;
            Salt = salt;
            Address = address;
            Account = account;
            CreatedAt = DateTime.UtcNow;
            // later should user should validate the account by email validation service
            IsActive = true;
        }
    }
}
