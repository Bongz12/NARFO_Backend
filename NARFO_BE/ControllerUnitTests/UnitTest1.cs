using NARFO_BE.Controllers;
using NARFO_BE.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace Tests
{
    
    public class Tests
    {
       
        public void GetAllMembers_ShouldReturnAllMembers()
        {
            var testMembers = GetTestMembers();
            
            var controller = new MembersController(testMembers);

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


    }
}