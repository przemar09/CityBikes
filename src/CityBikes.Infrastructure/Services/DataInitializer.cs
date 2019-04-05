using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Infrastructure.Services
{
    public class DataInitializer : IDataInitializer
    {
        private readonly IUserService _userService;
        private readonly ILogger<DataInitializer> _logger;

        public DataInitializer(IUserService userService, ILogger<DataInitializer> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        public async Task SeedAsync()
        {
            _logger.LogTrace("Initializing data...");
            var tasks = new List<Task>();
            for(int i = 1; i < 11; i++)
            {
                var guid = Guid.NewGuid();
                var username = $"username{i}";
                var lastname = $"lastname{i}";
                _userService.RegisterAsync(guid, username, lastname, $"{username}@email.com", "secret", "user");
            }
            for (int i = 1; i < 4; i++)
            {
                var guid = Guid.NewGuid();
                var username = $"admin{i}";
                var lastname = $"lastname{i}";
                _userService.RegisterAsync(guid, username, lastname, $"{username}@email.com", "secret", "admin");
            }
            await Task.WhenAll(tasks);
            _logger.LogTrace("Data was initialized.");
        }
    }
}
