using NARFO_BE;
using NARFO_BE.Models;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.TestHost;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace Tests
{

    public class Tests
    {


        private readonly HttpClient _client;
        private readonly narfoContext _context;
        public Tests()
        {
            // Set up server configuration
            var configuration = new ConfigurationBuilder()
                                // Indicate the path for our source code
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .Build();
            // Create builder
            var builder = new WebHostBuilder()
                            // Set test environment
                            .UseEnvironment("Testing")
                            .UseStartup<Startup>()
                            .UseConfiguration(configuration);
            // Create test server
            var server = new TestServer(builder);
            // Create database context
            this._context = server.Host.Services.GetService(typeof(narfoContext)) as narfoContext;
            // Create client to query server endpoints
            this._client = server.CreateClient();
        }

        [TestCase]
        public async Task GetMember_ShouldReturnMember()
        {
            /*
            // Create Member object
            string Password = "Password1";
            var newMember = new Member { Firstname = "Mike", Surname = " Jack", Username = "MikeJack", encryption.HashPassword(Password) };
            // Add heroes to database
            _context.Member.Add(newMember);
            _context.SaveChanges();
            // Request for the Member we just created
            */
            string member = "NM-000001";
            string name = "Johann Heirich";
            var response = await _client.GetAsync($"api/Member/get/{member}");
            // Check if status code is OK
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            // Get JSON  of the hero from response
            var jsonResponse = await response.Content.ReadAsStringAsync();
            // Deserialize response JSON to Members class
            var heroResponse = JsonConvert.DeserializeObject<Member>(jsonResponse);
            // Check if the Member is the same
           
           // Assert.AreEqual(name, heroResponse.Firstname);
        }



    }
}