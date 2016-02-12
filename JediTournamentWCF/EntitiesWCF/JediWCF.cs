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

        private string Nom { get; set; }
        private bool IsSith { get; set; }

        public JediWCF(Jedi j) {
            Nom = j.Nom;
            IsSith = j.IsSith;
        }
    }
}
