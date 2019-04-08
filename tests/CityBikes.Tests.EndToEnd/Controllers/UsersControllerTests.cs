using System.Text;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using FluentAssertions;
using CityBikes.Api;
using System.Net.Http;
using NUnit.Framework;
using Newtonsoft.Json;
using CityBikes.Infrastructure.DTO;
using System.Threading.Tasks;
using CityBikes.Infrastructure.Commands.Users;
using System.Net;
using Microsoft.AspNetCore;

namespace CityBikes.Tests.EndToEnd.Controllers
{
    public class UsersControllerTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public UsersControllerTests()
        {
            var webhost = WebHost.CreateDefaultBuilder().UseStartup<Startup>();
            _server = new TestServer(webhost);
            _client = _server.CreateClient();
        }

        [Test]
        public async Task given_email_should_return_user()
        {
            var email = "user1@email.com";
            var response = await _client.GetAsync($"users/{email}");
            var responseString = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<UserDto>(responseString);
            user.Email.Should().BeEquivalentTo(email);
        }

        [Test]
        public async Task registering_new_user_shuld_retrun_crated_http_code()
        {
            var request = new CreateUser()
            {
                Name = "User2",
                LastName = "Name2",
                Email = "user2@email.com",
                Password = "secret"
            };
            var json = JsonConvert.SerializeObject(request);
            var payload = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("users", payload);
            response.StatusCode.Should().BeEquivalentTo(HttpStatusCode.Created);
        }
    }
}
