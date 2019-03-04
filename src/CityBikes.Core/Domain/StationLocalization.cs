using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    public class StationLocalization : Localization
    {
        protected StationLocalization() : base()
        {

        }

        public StationLocalization(decimal longitude, decimal latitude) : base(longitude, latitude)
        {
            
        }
    }
}
