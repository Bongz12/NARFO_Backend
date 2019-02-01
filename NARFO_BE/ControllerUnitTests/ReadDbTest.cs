using NARFO_BE;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerUnitTests
{
    class ReadDbTest
    {
        private ReadFromDb read;

        public ReadDbTest()
        {
            read = new ReadFromDb();
        }

        [TestCase]
        public void ReadDb()
        {
            //assign
            var readTest = read.ReadDb();
            //act
            //Assert
            Assert.AreEqual("admin", readTest);
        }
    }
}
