using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Runtime.Serialization;

namespace JediTournamentWCF.EntitiesWCF {

    [DataContract]
    public class JediWCF {

        [DataMember]
        private string Nom { get; set; }
        [DataMember]
        private bool IsSith { get; set; }
        [DataMember]
        private List<CaracteristiqueWCF> Caracteristiques { get; set; }

        public JediWCF(Jedi j) {
            Nom = j.Nom;
            IsSith = j.IsSith;

            if (j.Caracteristiques != null) {
                Caracteristiques = new List<CaracteristiqueWCF>();
                foreach (Caracteristique c in j.Caracteristiques) {
                    Caracteristiques.Add(new CaracteristiqueWCF(c));
                }
            }
            else
                Caracteristiques = null;
            
        }
    }
}
