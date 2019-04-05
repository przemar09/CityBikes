using CityBikes.Infrastructure.Commands;
using CityBikes.Infrastructure.Commands.Users;
using CityBikes.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Infrastructure.Handlers.Users
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IUserService _userService;

        public CreateUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task HandleAsync(CreateUser command)
        {
            await _userService.RegisterAsync(command.UserId, command.Name, command.LastName, command.Email, command.Password, command.Role);
        }
    }
}
