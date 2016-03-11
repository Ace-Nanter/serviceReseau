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

        public static int ID = 0;

        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public int Valeur { get; set; }
        [DataMember]
        public int Definition { get; set; }
        [DataMember]
        public int Type { get; set; }

        public CaracteristiqueWCF(Caracteristique c) {
            Nom = c.Nom;
            this.Definition = (int) c.Definition;
            this.Type = (int) c.Type;
            Valeur = c.Valeur;
        }

        public Caracteristique convert() {
            EDefCaracteristique def = (EDefCaracteristique) this.Definition;
            ETypeCaracteristique type = (ETypeCaracteristique) this.Type;
            return new Caracteristique(ID++, def, this.Nom, type, this.Valeur);
        }
    }
}
