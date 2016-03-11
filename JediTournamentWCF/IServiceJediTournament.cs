using JediTournamentWCF.EntitiesWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JediTournamentWCF {
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceJediTournament" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceJediTournament {

        #region Jedis
        /// <summary>
        /// Get the Jedis list.
        /// </summary>
        /// <returns>List of Jedis.</returns>
        [OperationContract]
        List<JediWCF> getJedis();

        [OperationContract]
        bool updateJedis(List<JediWCF> jediList);
        #endregion

        /// <summary>
        /// Get the Stades list.
        /// </summary>
        /// <returns>List of Stades.</returns>
        [OperationContract]
        List<StadeWCF> getStades();

        /// <summary>
        /// Get the Matchs list.
        /// </summary>
        /// <returns>List of Matchs.</returns>
        [OperationContract]
        List<MatchWCF> getMatchs();

        /// <summary>
        /// Get the Tournament list.
        /// </summary>
        /// <returns>List of Tournaments.</returns>
        [OperationContract]
        List<TournoiWCF> getTournois();

        /// <summary>
        /// Get the caracs list.
        /// </summary>
        /// <returns>List of Caracteristics.</returns>
        [OperationContract]
        List<CaracteristiqueWCF> getCaracs();
    }
}
