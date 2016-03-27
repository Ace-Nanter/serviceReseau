using JediTournamentWebApp.JediTournamentWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JediTournamentWebApp.Models {
    public class TournoiWebModel {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Name")]
        public string Nom { get; set; }
       
        public TournoiWebModel() { }

        public TournoiWebModel(TournoiWCF t) {
            this.Id = t.Id;
            this.Nom = t.Nom;
        }
    }
}