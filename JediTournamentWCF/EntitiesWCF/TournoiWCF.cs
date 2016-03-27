using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JediTournamentWCF.EntitiesWCF {

    [DataContract]
    public class TournoiWCF {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nom { get; set; }

        public TournoiWCF() { }

        public TournoiWCF(Tournoi t) {
            this.Id = t.Id;
            this.Nom = t.Nom;
        }
    }
}
