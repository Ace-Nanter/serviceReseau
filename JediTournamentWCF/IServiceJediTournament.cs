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
        /// <summary>
        /// Get the Jedis list.
        /// </summary>
        /// <returns>List of Jedis.</returns>
        [OperationContract]
        List<JediWCF> getJedis();

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

        /// <summary>
        /// Insert a jedi in the database.
        /// </summary>
        /// <param name="jedi">Jedi to insert.</param>
        /// <returns>True if success, otherwise false.</returns>
        [OperationContract]
        bool AddJedi(JediWCF jedi);
    }

    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
