using CityBikes.Infrastructure.DTO;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBikes.Infrastructure.Extensions
{
    public static class CacheExtensions
    {
        public static void SetJwt(this IMemoryCache memoryCache, Guid tokenId, JwtDto jwt)
            => memoryCache.Set(GetJwtKey(tokenId), jwt, TimeSpan.FromSeconds(5));

        public static JwtDto GetJwt(this IMemoryCache memoryCache, Guid tokenId)
            => memoryCache.Get<JwtDto>(GetJwtKey(tokenId));

        private static string GetJwtKey(Guid tokenId)
            => $"jwt-{tokenId}";
    }
}
