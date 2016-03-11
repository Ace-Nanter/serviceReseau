using System;
using System.Collections.Generic;
using JediTournamentWCF.EntitiesWCF;
using EntitiesLayer;
using BusinessLayer;

namespace JediTournamentWCF {
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceJediTournament.svc ou ServiceJediTournament.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceJediTournament : IServiceJediTournament {
        
        #region Jedis

        private List<JediWCF> getJedis() {
            List<JediWCF> values = new List<JediWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach (Jedi j in manager.getJedis()) {
                values.Add(new JediWCF(j));
            }

            return values;
        }

        /// <summary>
        /// Obtenir tous les jedis
        /// </summary>
        /// <returns>Liste de tous les jedis.</returns>
        List<JediWCF> IServiceJediTournament.getJedis() {
            return this.getJedis();
        }

        bool IServiceJediTournament.updateJedis(List<JediWCF> jediList) {

            bool flag = true;
            List<Jedi> values = new List<Jedi>();
            
            foreach(JediWCF j in jediList) {
                values.Add(j.convert());
            }

            JediTournamentManager manager = new JediTournamentManager();
            manager.updateJedis(values);

            return flag;
        }

        #endregion

        #region Caractéristiques
        private List<CaracteristiqueWCF> getCaracs() {
            List<CaracteristiqueWCF> values = new List<CaracteristiqueWCF>();
            JediTournamentManager manager = new JediTournamentManager();
            List<Caracteristique> caracList = manager.getCaracteristiques();

            foreach (Caracteristique c in caracList) {
                values.Add(new CaracteristiqueWCF(c));
            }

            return values;
        }

        private bool updateCaracs(List<CaracteristiqueWCF> listCaracs) { 
            bool flag = true;
            List<Caracteristique> values = new List<Caracteristique>();
            try {

                // Converting
                foreach (CaracteristiqueWCF c in listCaracs) {
                    values.Add(c.convert());
                }

                // Update it
                JediTournamentManager manager = new JediTournamentManager();
                manager.updateCaracteristiques(values);
            }
            catch(Exception e) {
                flag = false;
            }
            
            return flag;
        }

        List<CaracteristiqueWCF> IServiceJediTournament.getCaracs() {
            return this.getCaracs();
        }
        #endregion

        List<MatchWCF> IServiceJediTournament.getMatchs() {
            List<MatchWCF> values = new List<MatchWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach(Match m in manager.getMatches()) {
                values.Add(new MatchWCF(m));
            }

            return values;
        }

        List<StadeWCF> IServiceJediTournament.getStades() {
            List<StadeWCF> values = new List<StadeWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach(Stade s in manager.getStades()) {
                values.Add(new StadeWCF(s));
            }

            return values;
        }

        List<TournoiWCF> IServiceJediTournament.getTournois() {
            throw new NotImplementedException();
        }
    }
}