using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CityBikes.Core.Domain;
using CityBikes.Core.Repositories;
using CityBikes.Infrastructure.DTO;

namespace CityBikes.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);
            return _mapper.Map<User, UserDto>(user);            
        }

        public async Task RegisterAsync(string name, string lastName,
           string email, string password)
        {
            var user = await _userRepository.GetAsync(email);
            if (user != null)
            {
                throw new Exception($"User with email: '{email}' already exists.");
            }
            var salt = Guid.NewGuid().ToString("N");
            user = new User(name, lastName, email, password, salt, null, null);
            await _userRepository.AddAsync(user);
        }
        //public async Task RegisterAsync(string name, string lastName, 
        //    string email, string password, string street, int number, int apartment, 
        //    string postalCode, string city, string country)
        //{
        //    var user = await _userRepository.GetAsync(email);
        //    if(user != null)
        //    {
        //        throw new Exception($"User with email: '{email}' already exists.");
        //    }
        //    var salt = Guid.NewGuid().ToString("N");
        //    user = new User(name, lastName, email, password, salt, Address.Create(
        //        street, number, apartment, postalCode, city, country), null);
        //    await _userRepository.AddAsync(user);

        //    await Task.CompletedTask;
        //}
    }
}
