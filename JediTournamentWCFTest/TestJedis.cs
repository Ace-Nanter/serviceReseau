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

        [TestMethod]
        public void JedisDeleteMethod() {
            using(ServiceJediTournamentEntities.ServiceJediTournamentClient client = new ServiceJediTournamentEntities.ServiceJediTournamentClient()) {
                List<JediWCF> testList = client.getJedis();

                Assert.AreNotEqual(0, testList.Count);

                int oldCount = testList.Count;

                List<int> toRemoveList = new List<int>();

                // Insert 5 jedis
                for (int i = 1; i <= 5; i++) {
                    JediWCF j = new JediWCF();
                    j.Id = testList[oldCount - 1].Id + i;
                    j.Nom = "test" + i;
                    j.IsSith = true;
                    j.Caracteristiques = new List<CaracteristiqueWCF>();

                    testList.Add(j);
                    toRemoveList.Add(j.Id);
                }

                client.updateJedis(testList);
                testList = client.getJedis();


                client.removeJedis(toRemoveList);
                testList = client.getJedis();
                Assert.AreEqual(testList.Count, oldCount);
            }
        }
    }
}
