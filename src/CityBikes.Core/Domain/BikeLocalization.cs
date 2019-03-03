using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    public class BikeLocalization : Localization
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }

        protected BikeLocalization() : base()
        {

        }

        public BikeLocalization(decimal longitude, decimal latitude) : base(longitude, latitude)
        {
            Id = Guid.NewGuid();
        }
    }
}
