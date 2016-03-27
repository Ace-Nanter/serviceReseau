using JediTournamentWebApp.JediTournamentWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediTournamentWebApp.Models {
    public class MatchWebModel {

        [Key]
        public int Id { get; set; }

        /* Jedi1, jedi2, Vainqueur, Stade, Phase(int) */

        [Required]
        [Display(Name = "Jedi 1")]
        public JediWebModel Jedi1 { get; set; }

        [Required]
        [Display(Name = "Jedi 2")]
        public JediWebModel Jedi2 { get; set; }

        [Required]
        [Display(Name = "Stadium")]
        public StadeWebModel Stade { get; set; }

        [Required]
        [Display(Name = "Phase")]
        public EPhaseWeb Phase { get; set; }

        [Display(Name = "Winner")]
        public JediWebModel Winner { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MatchWebModel() { }

        /// <summary>
        /// Constructor from a MatchWCF
        /// </summary>
        /// <param name="m">MatchWCF provided by the web service</param>
        public MatchWebModel(MatchWCF m) {
            Id = m.Id;
            Jedi1 = new JediWebModel(m.Jedi1);
            Jedi2 = new JediWebModel(m.Jedi2);
            Stade = new StadeWebModel(m.Stade);
            Phase = (EPhaseWeb) m.Phase;
            Winner = (m.Vainqueur == null) ? null : new JediWebModel(m.Vainqueur);
        }

        public MatchWCF convert() {
            MatchWCF m = new MatchWCF();
            m.Id = this.Id;
            m.Jedi1 = Jedi1.convert();
            m.Jedi2 = Jedi2.convert();
            m.Stade = Stade.convert();
            m.Phase = (int)Phase;
            m.Vainqueur = (this.Winner == null) ? null : Winner.convert();

            return m;
        }
    }
}
