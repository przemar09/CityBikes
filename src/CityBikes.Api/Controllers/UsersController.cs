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
    public class UsersController : Controller
    {
        private IUserService _userService;
        private readonly ICommandDispatcher _commandDispatcher;

        public UsersController(IUserService userService, ICommandDispatcher commandDispatcher)
        {
            _userService = userService;
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet("{email}")]
        public async Task<UserDto> GetAsync(string email)

            => await _userService.GetAsync(email);


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
            await _commandDispatcher.DispatchAsync(command);

            return Created($"users/{command.Email}", new object());
        }
    }

}