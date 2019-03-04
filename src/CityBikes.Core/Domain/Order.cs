using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    public class Order
    {
        public Guid Id { get; protected set; }
        public Bike Bike { get; protected set; }
        public User User { get; protected set; }
        public StationLocalization StationLocalization { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public DateTime? CompletedAt { get; protected set; }
        public decimal Cost { get; set; }

        protected Order()
        {

        }

        public Order(Bike bike, User user, StationLocalization stationLocalization)
        {
            Id = Guid.NewGuid();
            Bike = bike;
            User = user;
            StationLocalization = stationLocalization;
            CreatedAt = DateTime.UtcNow;
            CompletedAt = null;
            Cost = 0M;
        }
    }
}
