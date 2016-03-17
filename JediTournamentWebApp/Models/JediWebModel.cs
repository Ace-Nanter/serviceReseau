using JediTournamentWebApp.JediTournamentWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediTournamentWebApp.Models {
    public class JediWebModel {
        public string Nom { get; set; }
        public bool IsSith { get; set; }

        public List<CaracWebModel> Caracteristiques { get; set; }
        public JediWebModel(JediWCF j) {
            Nom = j.Nom;
            IsSith = j.IsSith;

            // Adaptation caractéristiques
            Caracteristiques = new List<CaracWebModel>();

            if (j.Caracteristiques != null) {
                foreach (CaracteristiqueWCF c in j.Caracteristiques) {
                    Caracteristiques.Add(new CaracWebModel(c));
                }
            }
        }
    }
}
