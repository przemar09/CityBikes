using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    public class Localization
    {
        public decimal Longitude { get; protected set; }
        public decimal Latitude { get; protected set; }

        protected Localization()
        {

        }

        public Localization(decimal longitude, decimal latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}