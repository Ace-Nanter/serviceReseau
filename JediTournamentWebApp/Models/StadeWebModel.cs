using JediTournamentWebApp.JediTournamentWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JediTournamentWebApp.Models {
    public class StadeWebModel {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Planet")]
        public string Planet { get; set; }

        [Required]
        [Display(Name = "Capacity")]
        public int nbPlaces { get; set; }

        [Display (Name ="Characteristics")]
        public List<CaracWebModel> Caracteristiques { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public StadeWebModel() {
            Caracteristiques = new List<CaracWebModel>();
        }

        public StadeWebModel(StadeWCF s) {
            Id = s.Id;
            Planet = s.Planet;
            nbPlaces = s.nbPlaces;

            // Adaptation caractéristiques
            Caracteristiques = new List<CaracWebModel>();

            if (s.Caracteristiques != null) {
                foreach (CaracteristiqueWCF c in s.Caracteristiques) {
                    Caracteristiques.Add(new CaracWebModel(c));
                }
            }
        }

        /// <summary>
        /// Convert a StadeWebModel into a StadeWCF
        /// </summary>
        /// <param name="id">Id to give to the new StadeWCF</param>
        /// <returns>A StadeWCF instance.</returns>
        public StadeWCF convert(int id) {
            StadeWCF s = new StadeWCF();
            s.Id = id;
            s.Planet = Planet;
            s.nbPlaces = nbPlaces;

            s.Caracteristiques = new List<CaracteristiqueWCF>();
            foreach(CaracWebModel c in this.Caracteristiques) {
                s.Caracteristiques.Add(c.convert(c.Id));
            }

            return s;
        }
    }
}