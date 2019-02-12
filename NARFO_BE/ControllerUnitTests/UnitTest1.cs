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
            string member = "NM-000001";
           
            var response = await _client.GetAsync($"api/Member/{member}");
            // Check if status code is OK
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
           
        }

        [TestCase]
        public async Task registerMember()
        {
            string mem = "MN - TESTTEST";


            var amembers = await _context.Member.FindAsync(mem);
            if (amembers != null)
            {
                _context.Member.Remove(amembers);
                await _context.SaveChangesAsync();

            }
            Member newMember = new Member
            {
                MemNo = "MN - TESTTEST",
                Username = "Nicky_Human",
                Title = "Mr",
                Password = Encryption.CreatePasswordHash("testtesttest"),
                Firstname = "Nicky",
                Surname = "Human",
                Idno = null,
                PhysicalAddress = null,
                Suburb = null,
                City = null,
                Province = null,
                PostalCode = null,
                CellNo = null,
                Email = "testest@smarttaccounting.co.za",
                MyBonusNo = null,
                Sex = "–",
                InceptionDate = null,
                // ExpiryDate = 2018 - 10 - 26T00 = 00 = 00,
                MemType = "Member",
                Ethinicity = "Black",


            };
            // Add heroes to database
            _context.Member.Add(newMember);
            _context.SaveChanges();
            // Set the value for the expected response (hero with min height)

            var response = await _client.GetAsync($"api/Member/{mem}");
            // Check if status code is OK
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }



    }
}