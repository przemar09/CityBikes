using Autofac;
using CityBikes.Infrastructure.Extensions;
using CityBikes.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Infrastructure.IoC.Modules
{
    public class SettingsModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public SettingsModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(_configuration
                   .GetSettings<GenralSettings>())
                   .SingleInstance();
            builder.RegisterInstance(_configuration
                   .GetSettings<JwtSettings>())
                   .SingleInstance();
        }
    }
}
