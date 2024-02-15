using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Authendication;
namespace UnitTestProject2Feb14
{
    [TestClass]
    public class AuthenticationTestClass
    {

        [TestMethod]
        public void SigInTest()
        {
            Auth at = new Auth();
            string failedCase = "Invalid Credencilas";
            string nullCase = "Provide username and password";
            string passCase = "Sigin success";
            Assert.AreEqual(nullCase, at.SigIn(null,null));
            Assert.AreEqual(passCase, at.SigIn("Suresh","Suresh@123"));
            //Assert.AreEqual(failedCase, at.SigIn("Invalid", "Inavlid@123"));
        }
    }
}
