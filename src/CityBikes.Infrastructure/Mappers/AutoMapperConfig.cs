using AutoMapper;
using CityBikes.Core.Domain;
using CityBikes.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<Address, AddressDto>();
                cfg.CreateMap<Account, AccountDto>();
            }).CreateMapper();
    }
}
