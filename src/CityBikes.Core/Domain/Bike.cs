using CityBikes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core
{
    public class Bike
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Mark { get; protected set; }
        public BikeType BikeType { get; protected set; }
        public BikeLocalization Localization { get; protected set; }
        public bool IsFree { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public Nullable<DateTime> RentedAt { get; protected set; }
        public Nullable<DateTime> ReturnedAt { get; protected set; }

        protected Bike()
        {
        }

        public Bike(string name, string mark, BikeType bikeType, BikeLocalization localization)
        {
            Id = Guid.NewGuid();
            Name = name;
            Mark = mark;
            BikeType = bikeType;
            Localization = localization;
            IsFree = true;
            CreatedAt = DateTime.UtcNow;
            RentedAt = null;
            ReturnedAt = null;
        }

        // Add validation methods

    }
}
