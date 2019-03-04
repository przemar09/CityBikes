using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    public class BikeLocalization : Localization
    {
        protected BikeLocalization() : base()
        {

        }

        public BikeLocalization(decimal longitude, decimal latitude) : base(longitude, latitude)
        {

        }
    }
}
