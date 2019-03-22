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
        Task RegisterAsync(string name, string lastName,
            string email, string password);
        Task LoginAsync(string email, string passowrd);
        //Task RegisterAsync(string name, string lastName,
        //    string email, string password, string street, int number, int apartment,
        //    string postalCode, string city, string country);
        // Task LoginAsync(string email, string password);
        // Task<IEnumerable<UserDto>> BrowseAsync();
    }
}
