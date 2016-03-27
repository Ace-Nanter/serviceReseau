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
        public int Id { get; set; }

        [DataMember]
        public JediWCF Jedi1 { get; set; }

        [DataMember]
        public JediWCF Jedi2 { get; set; }

        [DataMember]
        public JediWCF Vainqueur { get; set; }

        [DataMember]
        public StadeWCF Stade { get; set; }

        [DataMember]
        public int Phase { get; set; }

        public MatchWCF(Match m) {
            Id = m.Id;
            Jedi1 = new JediWCF(m.Jedi1);
            Jedi2 = new JediWCF(m.Jedi2);
            Vainqueur = (m.JediVainqueur == null) ? null : new JediWCF(m.JediVainqueur);
            Stade = new StadeWCF(m.Stade);
            Phase = (int) m.PhaseTournoi;
        }

        /// <summary>
        /// Convert a MatchWCF into a Match
        /// </summary>
        /// <returns>The Match instance of the given MatchWCF</returns>
        public Match convert() {

            Jedi v = (Vainqueur == null) ? null : Vainqueur.convert();

            return new Match(Id, Jedi1.convert(), Jedi2.convert(), (EPhaseTournoi)Phase, Stade.convert(), v);
        }
    }
}
