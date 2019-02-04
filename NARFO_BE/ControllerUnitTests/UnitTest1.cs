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
        public async Task GetAllMembers_ShouldReturnAllMembers()
        {
            // Create Member object
            var newMember = new Members { Id = 1, FirstName = "Mike", LastName = " Jack", Username = "MikeJack", Password = "Password1" };


            // Add heroes to database
            _context.Members.Add(newMember);
            _context.SaveChanges();

           // _context.Members.Add(newMember);
            //_context.SaveChanges();

            // Request for the Member we just created
            var response = await _client.GetAsync($"/api/Members/{newMember.Id}");
            // Check if status code is OK
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            // Get JSON  of the hero from response
            var jsonResponse = await response.Content.ReadAsStringAsync();
            // Deserialize response JSON to Members class
            var heroResponse = JsonConvert.DeserializeObject<Members>(jsonResponse);
            // Check if the Member is the same
            Assert.AreEqual(newMember.Id, heroResponse.Id);
            Assert.AreEqual(newMember.FirstName, heroResponse.FirstName);
        }


        /*

        [TestCase]
        public void GetAllMembers_ShouldReturnAllMembers()
        {
            var testMembers = GetTestMembers();
            
            var controller = new MembersController(_context);
            controller.ListofMembers(testMembers);

            var result = controller.GetAllMembers() as List<Members>;
            Assert.AreEqual(testMembers.Count, result.Count);
        }
        private List<Members> GetTestMembers()
        {
            var testMembers = new List<Members>();
            testMembers.Add(new Members { Id = 1, FirstName = "Mike", LastName =" Jack" , Username = "MikeJack", Password = "Password1" });
            testMembers.Add(new Members { Id = 2, FirstName = "Mike2", LastName = " Take", Username = "MikeJack2", Password = "Password1" });
            testMembers.Add(new Members { Id = 3, FirstName = "Mike3", LastName = " Late", Username = "MikeJack3", Password = "Password1" });
            testMembers.Add(new Members { Id = 4, FirstName = "Mike4", LastName = " Nate", Username = "MikeJack4", Password = "Password1" });

            return testMembers;
        }
        */

    }
}