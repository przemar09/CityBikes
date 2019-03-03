using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    public class Station
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public StationLocalization StationLocalization { get; protected set; }
        public Address Address { get; protected set; }
        public IEnumerable<Bike> Bikes { get; protected set; }

        protected Station()
        {

        }

        public Station(string name, StationLocalization stationLocalization, Address address)
        {
            Id = Guid.NewGuid();
            Name = name;
            StationLocalization = stationLocalization;
            Address = address;
        }
    }
}
