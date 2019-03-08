using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public async Task<UserDto> GetAsync(string email)

            => await _userService.GetAsync(email);


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateUser request)
        {
            await _userService.RegisterAsync(request.Name, request.LastName, request.Email, request.Password);

            return Created($"users/{request.Email}", new object());
        }
    }

}