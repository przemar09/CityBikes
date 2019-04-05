using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBikes.Infrastructure.Commands;
using CityBikes.Infrastructure.Commands.Users;
using CityBikes.Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace CityBikes.Api.Controllers
{
    public class LoginController : ApiControllerBase
    {
        private readonly IMemoryCache _memoryCache;

        public LoginController(ICommandDispatcher commandDispatcher, IMemoryCache memoryCache) : base(commandDispatcher)
        {
            _memoryCache = memoryCache;
        }

        public async Task<IActionResult> Post([FromBody]Login command)
        {
            command.TokenId = Guid.NewGuid();
            await CommandDispatcher.DispatchAsync(command);
            var jwt = _memoryCache.GetJwt(command.TokenId);

            return Json(jwt);
        }
    }
}
