using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.TestHost;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using NARFO_BE.Models;

namespace ControllerUnitTests
{   
    public class LoginTests
    {
        private readonly HttpClient _client;
        private readonly narfoContext _context;

        [TestCase]
        public async Task Login_MemberIsRegistered_ReturnTrue()
        {
            //Arrange
            Member member = new Member {
                Username = "John doe",
                Password = "123"

            };

            //Act


            var response = await _client.PostAsJsonAsync($"api/Member/post/login", member);

            //Assertion

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestCase]
        public async Task ALogin_MemberIsNotRegistered_ReturnFlase()
        {
            //Arrange
            Member member = new Member
            {
                Username = "Johndoe",
                Password = "123"

            };

            //Act


            var response = await _client.PostAsJsonAsync($"api/Member/post/login", member);

            //Assertion

            Assert.AreNotEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestCase]
        public async Task EmailLogin_MemberIsRegistered_ReturnTrue()
        {
            //Arrange
            Member member = new Member
            {
                Email = "John@doe.com",
                Password = "123"

            };

            //Act


            var response = await _client.PostAsJsonAsync($"api/Member/post/login", member);

            //Assertion

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }


        [TestCase]
        public async Task EmailLogin_MemberIsNotRegistered_ReturnFalse()
        {
            //Arrange
            Member member = new Member
            {
                Username = "John@doe.com",
                Password = "123"

            };

            //Act


            var response = await _client.PostAsJsonAsync($"api/Member/post/login", member);

            //Assertion

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
