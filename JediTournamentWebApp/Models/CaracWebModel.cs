using JediTournamentWebApp.JediTournamentWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediTournamentWebApp.Models {
    public class CaracWebModel {
        
        [Required]
        public string Nom { get; set; }

        [Required]
        public string Definition { get; set; }
        
        [Required]
        public int Valeur { get; set; }
        
        [Required]
        public int Type { get; set; }
        public CaracWebModel(CaracteristiqueWCF c) {

            Nom = c.Nom;
            Valeur = c.Valeur;

            switch(c.Definition) {
                case 0:
                    Definition = "Strength";
                    break;
                case 1:
                    Definition = "Dexterity";
                    break;
                case 2:
                    Definition = "Perception";
                    break;
                default:
                    Definition = "Unknown";
                    break;
            }

            Type = c.Type;
        }
    }
}
