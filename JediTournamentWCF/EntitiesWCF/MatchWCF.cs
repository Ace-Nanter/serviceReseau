using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace JediTournamentWCF.EntitiesWCF {

    [DataContract]
    public class MatchWCF {
        [DataMember]
        private JediWCF Jedi1 { get; set; }
        [DataMember]
        private JediWCF Jedi2 { get; set; }
        [DataMember]
        private StadeWCF Stade { get; set; }
        [DataMember]
        private EPhaseTournoi Phase { get; set; }

        public MatchWCF(Match m) {
            Jedi1 = new JediWCF(m.Jedi1);
            Jedi2 = new JediWCF(m.Jedi1);
            Stade = new StadeWCF(m.Stade);
            Phase = m.PhaseTournoi;
        }
    }
}
