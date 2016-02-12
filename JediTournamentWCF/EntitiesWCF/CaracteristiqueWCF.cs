using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace JediTournamentWCF.EntitiesWCF {

    [DataContract]
    public class CaracteristiqueWCF {

        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public int Valeur { get; set; }

        public CaracteristiqueWCF(Caracteristique c) {
            Nom = c.Nom;
            Valeur = c.Valeur;
        }
    }
}
