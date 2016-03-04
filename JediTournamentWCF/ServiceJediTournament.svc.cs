using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using JediTournamentWCF.EntitiesWCF;
using EntitiesLayer;
using BusinessLayer;

namespace JediTournamentWCF {
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceJediTournament.svc ou ServiceJediTournament.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceJediTournament : IServiceJediTournament {

        /// <summary>
        /// Obtenir tous les jedis
        /// </summary>
        /// <returns>Liste de tous les jedis.</returns>
        List<JediWCF> IServiceJediTournament.getJedis() {
            List<JediWCF> values = new List<JediWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach(Jedi j in manager.getJedis()) {
                values.Add(new JediWCF(j));
            }

            return values;
        }

        bool IServiceJediTournament.AddJedi(JediWCF jedi) {
            throw new NotImplementedException();
        }

        List<CaracteristiqueWCF> IServiceJediTournament.getCaracs() {
            List<CaracteristiqueWCF> values = new List<CaracteristiqueWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach(Jedi j in manager.getJedis()) {
                foreach(Caracteristique c in j.Caracteristiques) {
                    values.Add(new CaracteristiqueWCF(c));
                }
            }

            return values;
        }

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