using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Core.Domain
{
    public class Account
    {
        public Guid Id { get; protected set; }
        public decimal Credit { get; protected set; }

        protected Account()
        {

        }

        public Account(decimal credit)
        {
            Id = Guid.NewGuid();
            Credit = credit;
        }
    }
}
