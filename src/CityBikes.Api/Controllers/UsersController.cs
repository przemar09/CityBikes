using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBikes.Infrastructure.Commands;
using CityBikes.Infrastructure.Commands.Users;
using CityBikes.Infrastructure.DTO;
using CityBikes.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityBikes.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : ApiControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService, ICommandDispatcher commandDispatcher) 
            : base(commandDispatcher)
        {
            _userService = userService;
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