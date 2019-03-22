using System;
using System.Collections.Generic;
using System.Text;
using CityBikes.Infrastructure.DTO;

namespace CityBikes.Infrastructure.Services
{
    public class JwtHandler : IJwtHandler
    {
        public JwtDto CreateToken(string email, string role)
        {
            throw new NotImplementedException();
        }
    }
}
