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
        private readonly IEncrypter _encrypter;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IEncrypter encrypter, IMapper mapper)
        {
            _userRepository = userRepository;
            _encrypter = encrypter;
            _mapper = mapper;
        }

        public async Task<UserDto> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);
            return _mapper.Map<User, UserDto>(user);
        }

        public async Task LoginAsync(string email, string password)
        {
            var user = await _userRepository.GetAsync(email);
            if (user == null)
            {
                throw new Exception("Invalid credentials.");
            }
            var salt = _encrypter.GetSalt(password);
            var hash = _encrypter.GetHash(password, salt);
            if(user.Password == hash)
            {
                return;
            }
            throw new Exception("Invalid credentials.");
        }

        public async Task RegisterAsync(string name, string lastName,
           string email, string password)
        {
            var user = await _userRepository.GetAsync(email);
            if (user != null)
            {
                throw new Exception($"User with email: '{email}' already exists.");
            }
            var salt = _encrypter.GetSalt(password);
            var hash = _encrypter.GetHash(password, salt);
            user = new User(name, lastName, email, hash, salt, null, null);
            await _userRepository.AddAsync(user);
        }
    }
}
