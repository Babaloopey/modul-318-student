using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransportGui;
using NUnit.Framework;

namespace TestProject1
{
    
    public class TestMail
    {
        private Mail mail;
        string body = "Dies ist eine TestKonfiguration";
        [SetUp]
        public void Setup()
        {
            
            mail = new Mail(body);


        }
        [Test]
        public void CheckMail()
        {
            Assert.IsTrue(mail.Body == body);
        }
        [Test]
        public void TestSendMail()
        {
            try
            {
                mail.SendMail();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }


    }
}
