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
        public int Id { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public int Valeur { get; set; }
        [DataMember]
        public int Definition { get; set; }
        [DataMember]
        public int Type { get; set; }

        public CaracteristiqueWCF(Caracteristique c) {
            Id = c.Id;
            Nom = c.Nom;
            this.Definition = (int) c.Definition;
            this.Type = (int) c.Type;
            Valeur = c.Valeur;
        }

        public Caracteristique convert() {
            EDefCaracteristique def = (EDefCaracteristique) this.Definition;
            ETypeCaracteristique type = (ETypeCaracteristique) this.Type;
            return new Caracteristique(Id, def, this.Nom, type, this.Valeur);
        }
    }
}
