using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LOG660.FACADE;

namespace LOG660UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUserConnexion()
        {
            var web = WebFlixFacade.getInstance;            
            
            var u = WebFlixFacade.connectUserWithCredentials("reginald.augustin@gmail.com", "pwd");
            Assert.AreEqual(u, null);
        }
    }
}
