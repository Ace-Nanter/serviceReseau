using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JediTournamentWCFTest.ServiceJediTournamentEntities;

namespace JediTournamentWCFTest {
    [TestClass]
    public class TestCaracs {
        [TestMethod]
        public void CaracsSelectMethod() {
            ServiceJediTournamentEntities.ServiceJediTournamentClient client = new ServiceJediTournamentEntities.ServiceJediTournamentClient();
            List<CaracteristiqueWCF> testList = client.getCaracs();
            Assert.AreEqual(30, testList.Count);
            
            client.Close();
        }
    }
}
