using NARFO_API;

using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {
        

        /*[TestCase(1, "Jack", "Zulu", "Male", "2000/01/01")]

        public async Task Get(int value, string name, string surname, string gender, string dob)
        {

            //arrange
            //act
            //asse
            var worker = new Employees { Id = value, Name = name, Surname = surname, Gender = gender, Dob = dob };
            var url = String.Format( "dev.retrotest.co.za", "/api/Employees");
            var response = await _client.GetAsync("dev.retrotest.co.za");
            // Check if status code is OK
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            // Get JSON  of the worker from response
            var jsonResponse = await response.Content.ReadAsStringAsync();
            // Deserialize response JSON to Employee class
            var EmployeeResponse = JsonConvert.DeserializeObject<Employees>(jsonResponse);
            // Check if the employee is the same
            Assert.AreEqual(worker.Id, EmployeeResponse.Id);
            Assert.AreEqual(worker.Name, EmployeeResponse.Name);
            Assert.AreEqual(worker.Surname, EmployeeResponse.Surname);
            Assert.AreEqual(worker.Gender, EmployeeResponse.Gender);
            Assert.AreEqual(worker.Dob, EmployeeResponse.Dob);

        }*/

 
    }
}