using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Runtime.Serialization;

namespace JediTournamentWCF.EntitiesWCF {

    [DataContract]
    public class StadeWCF {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        private int nbPlaces { get; set; }
        [DataMember]
        private string Planet { get; set; }
        [DataMember]
        private List<CaracteristiqueWCF> Caracteristiques { get; set; }

        public StadeWCF(Stade s) {
            Id = s.Id;
            nbPlaces = s.NbPlaces;
            Planet = s.Planete;

            if (s.Caracteristiques != null) {
                Caracteristiques = new List<CaracteristiqueWCF>();
                foreach (Caracteristique c in s.Caracteristiques) {
                    Caracteristiques.Add(new CaracteristiqueWCF(c));
                }
            }
            else
                Caracteristiques = null;
        }

        /// <summary>
        /// Convert a StadeWCF into a Stade
        /// </summary>
        /// <returns>The Stade instance of the given StadeWCF</returns>
        public Stade convert() {
            List<Caracteristique> caracList = new List<Caracteristique>();
            foreach (CaracteristiqueWCF c in Caracteristiques) {
                caracList.Add(c.convert());
            }

            return new Stade(Id, this.nbPlaces, this.Planet, caracList);
        }
    }
}
