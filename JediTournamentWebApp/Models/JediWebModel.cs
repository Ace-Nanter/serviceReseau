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

        public JediWebModel(JediWCF j) {
            Nom = j.Nom;
            IsSith = j.IsSith;

            /*if (j.Caracteristiques != null) {
                Caracteristiques = new List<CaracteristiqueWCF>();
                foreach (Caracteristique c in j.Caracteristiques) {
                    Caracteristiques.Add(new CaracteristiqueWCF(c));
                }
            }
            else
                Caracteristiques = null;
                */
        }
    }
}
