using NARFO_BE;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerUnitTests
{
    public class ConnectionToDbTest
    {
        private ConnectionToDb connect;

        public ConnectionToDbTest()
        {
            connect = new ConnectionToDb();
        }

        [TestCase]
        public void DatabaseConnection()
        {
            //assign
            var Opentest = connect.DBConnection();
            //act
            //assert
            Assert.AreEqual("Open", Opentest);
        }
    }
}
