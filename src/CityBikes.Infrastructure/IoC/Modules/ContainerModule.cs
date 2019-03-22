using Autofac;
using CityBikes.Infrastructure.Mappers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Infrastructure.IoC.Modules
{
    public class ContainerModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public ContainerModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(AutoMapperConfig.Initialize()).SingleInstance();
            builder.RegisterModule<CommandModule>();
            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule(new SettingsModule(_configuration));
        }
    }
}
