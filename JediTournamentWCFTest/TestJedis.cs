using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JediTournamentWCFTest.ServiceJediTournamentEntities;

namespace JediTournamentWCFTest {
    [TestClass]
    public class TestJedis {
        [TestMethod]
        public void SelectMethod() {
            ServiceJediTournamentEntities.ServiceJediTournamentClient client = new ServiceJediTournamentEntities.ServiceJediTournamentClient();
            List<JediWCF> testList = client.getJedis();
            //Assert.AreNotEqual(0, testList.Count);

            client.Close();
        }
    }
}
