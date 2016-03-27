using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace JediTournamentWebApp.Models {
    public enum EPhaseWeb {
        [Description("Huitieme-Finale 1")]
        HuitiemeFinale1 = 14,

        [Description("Huitieme-Finale 2")]
        HuitiemeFinale2 = 13,

        [Description("Huitieme-Finale 3")]
        HuitiemeFinale3 = 12,

        [Description("Huitieme-Finale 4")]
        HuitiemeFinale4 = 11,

        [Description("Huitieme-Finale 5")]
        HuitiemeFinale5 = 10,

        [Description("Huitieme-Finale 6")]
        HuitiemeFinale6 = 9,

        [Description("Huitieme-Finale 7")]
        HuitiemeFinale7 = 8,

        [Description("Huitieme-Finale 8")]
        HuitiemeFinale8 = 7,

        [Description("Quart-Finale 1")]
        QuartFinale1 = 6,

        [Description("Quart-Finale 2")]
        QuartFinale2 = 5,

        [Description("Quart-Finale 3")]
        QuartFinale3 = 4,

        [Description("Quart-Finale 4")]
        QuartFinale4 = 3,

        [Description("Demi-Finale 1")]
        DemiFinale1 = 2,

        [Description("Demi-Finale 2")]
        DemiFinale2 = 1,

        [Description("Finale")]
        Finale = 0
    }
}