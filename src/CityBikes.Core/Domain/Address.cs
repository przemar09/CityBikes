using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    // Value Type DDD
    public class Address
    {
        public string Street { get; protected set; }
        public int Number { get; protected set; }
        public int Apartment { get; protected set; }
        public string PostalCode { get; protected set; }
        public string City { get; protected set; }
        public string Country { get; protected set; }

        protected Address()
        {

        }

        protected Address(string street, int number, int apartment, string postalCode, string city, string country)
        {
            SetStreet(street);
            SetNumber(number);
            SetApartment(apartment);
            SetPostalCode(postalCode);
            SetCity(city);
            SetCountry(country);
        }

        private void SetStreet(string street)
        {
            if(string.IsNullOrWhiteSpace(street))
            {
                throw new Exception("Please provide valid data.");
            }
            if(Street == street)
            {
                return;
            }
            Street = street;
        }

        private void SetNumber(int number)
        {
            if (number <= 0)
            {
                throw new Exception("Street number cannot be less than 1.");
            }
            if (Number == number)
            {
                return;
            }
            Number = number;
        }

        private void SetApartment(int apartment)
        {
            if (apartment <= 0)
            {
                throw new Exception("Apartment number cannot be less than 1.");
            }
            if (Apartment == apartment)
            {
                return;
            }
            Apartment = apartment;
        }

        private void SetPostalCode(string postalCode)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                throw new Exception("Please provide valid data.");
            }
            if (PostalCode == postalCode)
            {
                return;
            }
            PostalCode = postalCode;
        }

        private void SetCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new Exception("Please provide valid data.");
            }
            if (City == city)
            {
                return;
            }
            City = city;
        }

        private void SetCountry(string country)
        {
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new Exception("Please provide valid data.");
            }
            if (Country == country)
            {
                return;
            }
            Country = country;
        }

        public static Address Create(string street, int number, int apartment,
            string postalCode, string city, string country)

            => new Address(street, number, apartment, postalCode, city, country);
        
    }
}
