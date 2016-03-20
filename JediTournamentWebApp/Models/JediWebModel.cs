using JediTournamentWebApp.JediTournamentWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediTournamentWebApp.Models {
    public class JediWebModel {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Nom { get; set; }

        [Required]
        [Display(Name = "Force side")]
        public bool IsSith { get; set; }

        
        [Display (Name = "Caracteristics")]
        public List<CaracWebModel> Caracteristiques { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public JediWebModel() {
            Caracteristiques = new List<CaracWebModel>();
        }

        /// <summary>
        /// Constructor from a JediWCF 
        /// </summary>
        /// <param name="j">JediWCF provided by the web service</param>
        public JediWebModel(JediWCF j) {
            Id = j.Id;
            Nom = j.Nom;
            IsSith = j.IsSith;

            // Adaptation caractéristiques
            Caracteristiques = new List<CaracWebModel>();

            if (j.Caracteristiques != null) {
                int i = 0;
                foreach (CaracteristiqueWCF c in j.Caracteristiques) {
                    Caracteristiques.Add(new CaracWebModel(c, i++));
                }
            }
        }

        public JediWCF convert(int id) {
            JediWCF j = new JediWCF();
            j.Id = id;
            j.Nom = this.Nom;
            j.IsSith = this.IsSith;

            j.Caracteristiques = new List<CaracteristiqueWCF>();

            foreach(CaracWebModel c in this.Caracteristiques) {
                j.Caracteristiques.Add(c.convert());
            }

            return j;
        }
    }
}
