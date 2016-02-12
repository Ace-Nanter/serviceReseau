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
            throw new NotImplementedException();
        }

        string IServiceJediTournament.GetData(int value) {
            throw new NotImplementedException();
        }

        CompositeType IServiceJediTournament.GetDataUsingDataContract(CompositeType composite) {
            throw new NotImplementedException();
        }

        

        List<MatchWCF> IServiceJediTournament.getMatchs() {
            throw new NotImplementedException();
        }

        List<StadeWCF> IServiceJediTournament.getStades() {
            throw new NotImplementedException();
        }

        List<TournoiWCF> IServiceJediTournament.getTournois() {
            throw new NotImplementedException();
        }



        /*

                public string GetData(int value) {
                    return string.Format("You entered: {0}", value);
                }

                public CompositeType GetDataUsingDataContract(CompositeType composite) {
                    if (composite == null) {
                        throw new ArgumentNullException("composite");
                    }
                    if (composite.BoolValue) {
                        composite.StringValue += "Suffix";
                    }
                    return composite;
                }
                */



    }
}