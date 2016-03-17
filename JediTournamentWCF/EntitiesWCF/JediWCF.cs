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
        public int Id { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public bool IsSith { get; set; }
        [DataMember]
        public List<CaracteristiqueWCF> Caracteristiques { get; set; }

        public JediWCF(Jedi j) {
            Id = j.Id;
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

        /// <summary>
        /// Convert a JediWCF into a Jedi
        /// </summary>
        /// <param name="i">ID of the created Jedi.</param>
        /// <returns>The Jedi instance of the given JediWCF</returns>
        public Jedi convert() {
            List<Caracteristique> caracList = new List<Caracteristique>();
            foreach(CaracteristiqueWCF c in this.Caracteristiques) {
                caracList.Add(c.convert());
            }

            return new Jedi(Id, caracList, this.IsSith, this.Nom);
        }
    }
}
