using CityBikes.Infrastructure.Commands;
using CityBikes.Infrastructure.Commands.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBikes.Api.Controllers
{
    [Route("[controller]")]
    public class AccountsController : ApiControllerBase
    {
        public AccountsController(ICommandDispatcher commandDispatcher)
            : base(commandDispatcher)
        {
        }

        [HttpPost]
        [Route("password")]
        public async Task<IActionResult> Put([FromBody]ChangeUserPassword command)
        {
            await CommandDispatcher.DispatchAsync(command);

            return NoContent();
        }
    }
}
