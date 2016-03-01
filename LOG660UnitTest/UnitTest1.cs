using System;
using System.Data.Linq;
using System.Linq;
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

        public void TestCheckUserMaxLocationAmount() 
        {
            var user = "ThomasCBaggett12@yahoo.com";
            var password = "vonej2ooT";

            var fullUser = (from f in WebFlixFacade.getInstance.getEntity.USAGERs
                                where f.COURRIEL.Equals(user) && f.MOTPASSE.Equals(password)
                                select f).First();


            var maxLocations = (from forfait in WebFlixFacade.getInstance.getEntity.FORFAITs
                                where forfait.IDFORFAIT == fullUser.CLIENTs.First(c => c.IDUSAGER == fullUser.IDUSAGER).IDFORFAIT
                                select forfait).First();

            Assert.AreEqual(4, maxLocations.LOCATIONMAX);



        }
    }
}
