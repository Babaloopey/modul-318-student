using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransportGui;
using NUnit.Framework;

namespace TestProject1
{
    public class TestHelper
    {
        private Helper helper;
        [SetUp]
        public void Setup()
        {
            helper = new Helper();
        }
        [Test]
        public void TestGetConnections()
        {

        }

    }
}
