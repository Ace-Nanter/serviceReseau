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

        List<JediWCF> IServiceJediTournament.getJedis() {
            List<JediWCF> values = new List<JediWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach(Jedi j in manager.getAllJedis()) {
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

            foreach(Jedi j in manager.getAllJedis()) {
                foreach(Caracteristique c in j.Caracteristiques) {
                    values.Add(new CaracteristiqueWCF(c));
                }
            }

            return values;
        }

        List<MatchWCF> IServiceJediTournament.getMatchs() {
            List<MatchWCF> values = new List<MatchWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach(Match m in manager.getAllMatchs()) {
                values.Add(new MatchWCF(m));
            }

            return values;
        }

        List<StadeWCF> IServiceJediTournament.getStades() {
            List<StadeWCF> values = new List<StadeWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach(Stade s in manager.getAllStades()) {
                values.Add(new StadeWCF(s));
            }

            return values;
        }

        List<TournoiWCF> IServiceJediTournament.getTournois() {
            throw new NotImplementedException();
        }
    }
}