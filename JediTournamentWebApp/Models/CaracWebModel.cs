using JediTournamentWebApp.JediTournamentWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediTournamentWebApp.Models {
    public class CaracWebModel {
        
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Nom { get; set; }

        [Required]
        [Display(Name = "Definition")]
        public DefCaracWeb Definition { get; set; }
        
        [Required]
        [Display(Name = "Value")]
        [Range(0, 100)]
        public int Valeur { get; set; }
        
        [Required]
        public int Type { get; set; }
        public CaracWebModel(CaracteristiqueWCF c, int i) {
            Id = i;
            Nom = c.Nom;
            Valeur = c.Valeur;
            Definition = (DefCaracWeb) c.Definition;
            Type = c.Type;
        }

        public CaracteristiqueWCF convert() {
            CaracteristiqueWCF c = new CaracteristiqueWCF();
            c.Definition = (int)this.Definition;
            c.Nom = this.Nom;
            c.Valeur = this.Valeur;
            c.Type = this.Type;

            return c;
        }
    }
}
