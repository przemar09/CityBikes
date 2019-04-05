using CityBikes.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Infrastructure.Services
{
    public interface IUserService : IService
    {
        Task<UserDto> GetAsync(string email);
        Task RegisterAsync(Guid userId, string name, string lastName,
            string email, string password, string role);
        Task LoginAsync(string email, string passowrd);
    }
}
