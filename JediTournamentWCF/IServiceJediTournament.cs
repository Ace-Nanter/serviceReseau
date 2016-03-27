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

        #region Caracteristiques
        /// <summary>
        /// Récupère la liste des caractéristiques
        /// </summary>
        /// <returns>La liste des caractéristiques</returns>
        [OperationContract]
        List<CaracteristiqueWCF> getCaracs();

        /// <summary>
        /// Ajoute une nouvelle caracteristique
        /// </summary>
        /// <param name="item">Caracteristique à ajouter</param>
        /// <returns>Vrai si l'ajout s'est fait, sinon faux</returns>
        [OperationContract]
        bool newCarac(CaracteristiqueWCF item);

        /// <summary>
        /// Supprime les caractéristiques dont les IDs sont donnés en paramètre
        /// </summary>
        /// <param name="removeList">Liste des IDs des caractéristiques à supprimer</param>
        /// <returns>Vrai si succès, sinon faux</returns>
        [OperationContract]
        bool removeCarac(List<int> removeList);

        /// <summary>
        /// Modifie la liste des caractéristiques par celle donnée en argument
        /// </summary>
        /// <param name="listCaracs">Nouvelle liste de caractéristiques</param>
        /// <returns>Vrai si la mise à jour a bien eu lieu, faux sinon</returns>
        [OperationContract]
        bool updateCaracs(List<CaracteristiqueWCF> caracList);

        #endregion

        #region Jedis

        /// <summary>
        /// Récupère la liste des jedis
        /// </summary>
        /// <returns>La liste des jedis</returns>
        [OperationContract]
        List<JediWCF> getJedis();

        /// <summary>
        /// Ajoute un nouveau jedi
        /// </summary>
        /// <param name="item">Jedi à ajouter</param>
        /// <returns>Vrai si l'ajout s'est fait, sinon faux</returns>
        [OperationContract]
        bool newJedi(JediWCF item);

        /// <summary>
        /// Supprime les jedis dont les IDs sont donnés en paramètre
        /// </summary>
        /// <param name="removeList">Liste des IDs des jedis à supprimer</param>
        /// <returns>Vrai si succès, sinon faux</returns>
        [OperationContract]
        bool removeJedis(List<int> removeList);

        /// <summary>
        /// Modifie la liste des jedis par celle donnée en argument
        /// </summary>
        /// <param name="jediList">Nouvelle liste de jedis</param>
        /// <returns>Vrai si la mise à jour a bien eu lieu, faux sinon</returns>
        [OperationContract]
        bool updateJedis(List<JediWCF> jediList);

        #endregion

        #region Stades

        /// <summary>
        /// Récupère la liste des stades
        /// </summary>
        /// <returns>La liste des stades</returns>
        [OperationContract]
        List<StadeWCF> getStades();

        /// <summary>
        /// Ajoute un nouveau stade
        /// </summary>
        /// <param name="item">Stade à ajouter</param>
        /// <returns>Vrai si l'ajout s'est fait, sinon faux</returns>
        [OperationContract]
        bool newStade(StadeWCF item);

        /// <summary>
        /// Supprime les stades dont les IDs sont donnés en paramètre
        /// </summary>
        /// <param name="removeList">Liste des IDs des stades à supprimer</param>
        /// <returns>Vrai si succès, sinon faux</returns>
        [OperationContract]
        bool removeStades(List<int> removeList);

        /// <summary>
        /// Modifie la liste des stades par celle donnée en argument
        /// </summary>
        /// <param name="stadeList">Nouvelle liste de stades</param>
        /// <returns>Vrai si la mise à jour a bien eu lieu, faux sinon</returns>
        [OperationContract]
        bool updateStades(List<StadeWCF> stadeList);

        #endregion

        #region Matchs
        /// <summary>
        /// Get the Matchs list.
        /// </summary>
        /// <returns>List of Matchs.</returns>
        [OperationContract]
        List<MatchWCF> getMatchs();

        /// <summary>
        /// Ajoute un nouveau match.
        /// </summary>
        /// <param name="m">Match à ajouter</param>
        /// <returns>Vrai si l'ajout s'est fait, sinon faux</returns>
        [OperationContract]
        bool newMatch(MatchWCF item);

        /// <summary>
        /// Supprime les matchs dont les IDs sont donnés en paramètre
        /// </summary>
        /// <param name="removeList">Liste des IDs des matchs à supprimer</param>
        /// <returns>Vrai si succès, sinon faux</returns>
        [OperationContract]
        bool removeMatch(List<int> ids);

        /// <summary>
        /// Modifie la liste des matchs par celle donnée en argument
        /// </summary>
        /// <param name="matchList">Nouvelle liste de matchs</param>
        /// <returns>Vrai si la mise à jour a bien eu lieu, faux sinon</returns>
        bool updateMatchs(List<MatchWCF> matchList);

        #endregion Matchs

            /// <summary>
            /// Get the Tournament list.
            /// </summary>
            /// <returns>List of Tournaments.</returns>
        [OperationContract]
        List<TournoiWCF> getTournois();

        [OperationContract]
        bool launchTournoi(int tournoiId);

    }
}
