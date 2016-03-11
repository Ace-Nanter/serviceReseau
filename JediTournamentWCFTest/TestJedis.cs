using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JediTournamentWCFTest.ServiceJediTournamentEntities;

namespace JediTournamentWCFTest {
    [TestClass]
    public class TestJedis {
        [TestMethod]
        public void JedisSelectMethod() {
            ServiceJediTournamentEntities.ServiceJediTournamentClient client = new ServiceJediTournamentEntities.ServiceJediTournamentClient();
            List<JediWCF> testList = client.getJedis();
            Assert.AreNotEqual(0, testList.Count);

            client.Close();
        }

        [TestMethod]
        public void JedisUpdateMethod() {
            ServiceJediTournamentEntities.ServiceJediTournamentClient client = new ServiceJediTournamentEntities.ServiceJediTournamentClient();
            List<JediWCF> testList = client.getJedis();

            Assert.AreNotEqual(0, testList.Count);

            int count = testList.Count;

            JediWCF j = new JediWCF();
            j.Nom = "test";
            j.IsSith = true;
            j.Caracteristiques = new List<CaracteristiqueWCF>();


            testList.Add(j);

            client.updateJedis(testList);

            testList = null;
            testList = client.getJedis();

            Assert.AreEqual(count + 1, testList.Count);

            client.Close();
        }
    }
}
