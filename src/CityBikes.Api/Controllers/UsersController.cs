using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBikes.Infrastructure.Commands;
using CityBikes.Infrastructure.Commands.Users;
using CityBikes.Infrastructure.DTO;
using CityBikes.Infrastructure.Services;
using CityBikes.Infrastructure.Settings;
using Microsoft.AspNetCore.Mvc;

namespace CityBikes.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : ApiControllerBase
    {
        private IUserService _userService;
        private readonly GenralSettings _genralSettings;

        public UsersController(IUserService userService, ICommandDispatcher commandDispatcher,
            GenralSettings genralSettings) 
            : base(commandDispatcher)
        {
            _userService = userService;
            _genralSettings = genralSettings;
        }

        [HttpGet]
        public async Task<GenralSettings> Get()
        {
            return _genralSettings;
        }

        [HttpGet("{email}")]
        public async Task<UserDto> GetAsync(string email)

            => await _userService.GetAsync(email);
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
            await CommandDispatcher.DispatchAsync(command);

            return Created($"users/{command.Email}", new object());
        }
    }

}