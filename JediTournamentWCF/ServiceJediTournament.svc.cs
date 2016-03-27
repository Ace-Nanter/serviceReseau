using System;
using System.Collections.Generic;
using JediTournamentWCF.EntitiesWCF;
using EntitiesLayer;
using BusinessLayer;
using System.Linq;

namespace JediTournamentWCF {
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceJediTournament.svc ou ServiceJediTournament.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceJediTournament : IServiceJediTournament {

        #region Caractéristiques

        /// <summary>
        /// Retourne la liste de toutes les caractéristiques
        /// </summary>
        /// <returns>Liste de toutes les caractéristiques</returns>
        List<CaracteristiqueWCF> IServiceJediTournament.getCaracs() {
            List<CaracteristiqueWCF> values = new List<CaracteristiqueWCF>();
            JediTournamentManager manager = new JediTournamentManager();
            List<Caracteristique> caracList = manager.getCaracteristiques();

            // Conversion des caractéristiques
            foreach (Caracteristique c in caracList) {
                values.Add(new CaracteristiqueWCF(c));
            }

            return values;
        }

        /// <summary>
        /// Ajoute une nouvelle caracteristique
        /// </summary>
        /// <param name="c">Caracteristique à ajouter</param>
        /// <returns>Vrai si l'ajout s'est fait, sinon faux</returns>
        bool IServiceJediTournament.newCarac(CaracteristiqueWCF item) {
            bool flag = true;

            
            JediTournamentManager manager = new JediTournamentManager();
            List<Caracteristique> values = manager.getCaracteristiques();

            // Mise en place de l'ID correct et ajout
            item.Id = values.Max(c => c.Id);
            values.Add(item.convert());

            try {
                manager.updateCaracteristiques(values);
            }
            catch {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// Supprime les caractéristiques dont les IDs sont donnés en paramètre
        /// </summary>
        /// <param name="removeList">Liste des IDs des caractéristiques à supprimer</param>
        /// <returns>Vrai si succès, sinon faux</returns>
        bool IServiceJediTournament.removeCarac(List<int> removeList) {
            bool flag = true;
            List<Caracteristique> values = new List<Caracteristique>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach (Caracteristique c in manager.getCaracteristiques()) {
                // Si l'ID n'est pas contenu dans la liste des IDs à supprimer on l'ajoute aux nouvelles valeurs
                if (!removeList.Contains(c.Id)) {
                    values.Add(c);
                }
            }

            try {
                manager.updateCaracteristiques(values);
            }
            catch {
                flag = false;
            }
            
            return flag;
        }

        /// <summary>
        /// Modifie la liste des caractéristiques par celle donnée en argument
        /// </summary>
        /// <param name="listCaracs">Nouvelle liste de caractéristiques</param>
        /// <returns>Vrai si la mise à jour a bien eu lieu, faux sinon</returns>
        private bool updateCaracs(List<CaracteristiqueWCF> listCaracs) {

            bool flag = true;
            List<Caracteristique> values = new List<Caracteristique>();
            try {

                // Converting
                foreach (CaracteristiqueWCF c in listCaracs) {
                    values.Add(c.convert());
                }

                // Update it
                JediTournamentManager manager = new JediTournamentManager();
                manager.updateCaracteristiques(values);
            }
            catch {
                flag = false;
            }

            return flag;
        }

        bool IServiceJediTournament.updateCaracs(List<CaracteristiqueWCF> caracList) {
            return this.updateCaracs(caracList);
        }
        #endregion

        #region Jedis

        /// <summary>
        /// Récupère la liste des jedis
        /// </summary>
        /// <returns>La liste des jedis</returns>
        private List<JediWCF> getJedis() {
            List<JediWCF> values = new List<JediWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach (Jedi j in manager.getJedis()) {
                values.Add(new JediWCF(j));
            }

            return values;
        }

        /// <summary>
        /// Récupère la liste des jedis
        /// </summary>
        /// <returns>La liste des jedis</returns>
        List<JediWCF> IServiceJediTournament.getJedis() {
            return getJedis();
        }

        /// <summary>
        /// Ajoute un nouveau jedi
        /// </summary>
        /// <param name="j">Jedi à ajouter</param>
        /// <returns>Vrai si l'ajout s'est fait, sinon faux</returns>
        bool IServiceJediTournament.newJedi(JediWCF item) {
            bool flag = true;
            
            JediTournamentManager manager = new JediTournamentManager();
            List<Jedi> values = manager.getJedis();
            item.Id = values.Max(j => j.Id);
            values.Add(item.convert());

            try {
                manager.updateJedis(values);
            }
            catch {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// Supprime les jedis dont les IDs sont donnés en paramètre
        /// </summary>
        /// <param name="removeList">Liste des IDs des jedis à supprimer</param>
        /// <returns>Vrai si succès, sinon faux</returns>
        bool IServiceJediTournament.removeJedis(List<int> ids) {

            bool flag = true;
            List<Jedi> values = new List<Jedi>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach (Jedi j in manager.getJedis()) {
                if (!ids.Contains(j.Id)) {
                    values.Add(j);
                }
            }

            try {
                manager.updateJedis(values);
            }
            catch {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// Modifie la liste des stades par celle donnée en argument
        /// </summary>
        /// <param name="listCaracs">Nouvelle liste de stades</param>
        /// <returns>Vrai si la mise à jour a bien eu lieu, faux sinon</returns>
        bool IServiceJediTournament.updateJedis(List<JediWCF> jediList) {

            bool flag = true;
            List<Jedi> values = new List<Jedi>();
            
            foreach(JediWCF j in jediList) {
                values.Add(j.convert());
            }

            JediTournamentManager manager = new JediTournamentManager();
            manager.updateJedis(values);

            return flag;
        }

        #endregion

        #region Stades

        /// <summary>
        /// Récupère la liste des stades
        /// </summary>
        /// <returns>La liste des stades</returns>
        private List<StadeWCF> getStades() {
            List<StadeWCF> values = new List<StadeWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach (Stade s in manager.getStades()) {
                values.Add(new StadeWCF(s));
            }

            return values;
        }

        /// <summary>
        /// Récupère la liste des stades
        /// </summary>
        /// <returns>La liste des stades</returns>
        List<StadeWCF> IServiceJediTournament.getStades() {
            return getStades();
        }

        /// <summary>
        /// Ajoute un nouveau stade
        /// </summary>
        /// <param name="s">Stade à ajouter</param>
        /// <returns>Vrai si l'ajout s'est fait, sinon faux</returns>
        bool IServiceJediTournament.newStade(StadeWCF item) {
            bool flag = true;

            JediTournamentManager manager = new JediTournamentManager();
            List<Stade> values = manager.getStades();

            // Mise en place de l'ID correct et ajout
            item.Id = values.Max(s => s.Id);
            values.Add(item.convert());

            try {
                manager.updateStades(values);
            }
            catch {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// Supprime les jedis dont les IDs sont donnés en paramètre
        /// </summary>
        /// <param name="removeList">Liste des IDs des jedis à supprimer</param>
        /// <returns>Vrai si succès, sinon faux</returns>
        bool IServiceJediTournament.removeStades(List<int> ids) {

            bool flag = true;
            List<Stade> values = new List<Stade>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach (Stade s in manager.getStades()) {
                if (!ids.Contains(s.Id)) {
                    values.Add(s);
                }
            }

            try {
                manager.updateStades(values);
            }
            catch {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// Modifie la liste des stades par celle donnée en argument
        /// </summary>
        /// <param name="listCaracs">Nouvelle liste de stades</param>
        /// <returns>Vrai si la mise à jour a bien eu lieu, faux sinon</returns>
        bool IServiceJediTournament.updateStades(List<StadeWCF> stadeList) {

            bool flag = true;
            List<Stade> values = new List<Stade>();

            foreach (StadeWCF s in stadeList) {
                values.Add(s.convert());
            }

            JediTournamentManager manager = new JediTournamentManager();
            manager.updateStades(values);

            return flag;
        }

        #endregion

        #region Matchs
        /// <summary>
        /// Récupère la liste des matchs
        /// </summary>
        /// <returns>La liste des matchs</returns>
        private List<MatchWCF> getMatchs() {
            List<MatchWCF> values = new List<MatchWCF>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach (Match m in manager.getMatches()) {
                if( (m.Jedi1 != null && m.Jedi1.Id != 0)
                    && (m.Jedi2 != null && m.Jedi2.Id != 0)) {
                    values.Add(new MatchWCF(m));
                }
            }

            return values;
        }

        /// <summary>
        /// Récupère la liste des matchs
        /// </summary>
        /// <returns>La liste des matchs</returns>
        List<MatchWCF> IServiceJediTournament.getMatchs() {
            return getMatchs();
        }

        /// <summary>
        /// Ajoute un nouveau match.
        /// </summary>
        /// <param name="m">Match à ajouter</param>
        /// <returns>Vrai si l'ajout s'est fait, sinon faux</returns>
        bool IServiceJediTournament.newMatch(MatchWCF item) {
            bool flag = true;

            JediTournamentManager manager = new JediTournamentManager();
            List<Match> values = manager.getMatches();

            // Mise en place de l'ID correct et ajout
            item.Id = values.Max(m => m.Id);
            values.Add(item.convert());

            try {
                manager.updateMatches(values);
            }
            catch {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// Supprime les matchs dont les IDs sont donnés en paramètre
        /// </summary>
        /// <param name="removeList">Liste des IDs des matchs à supprimer</param>
        /// <returns>Vrai si succès, sinon faux</returns>
        bool IServiceJediTournament.removeMatch(List<int> ids) {

            bool flag = true;
            List<Match> values = new List<Match>();
            JediTournamentManager manager = new JediTournamentManager();

            foreach (Match m in manager.getMatches()) {
                if (!ids.Contains(m.Id)) {
                    values.Add(m);
                }
            }

            try {
                manager.updateMatches(values);
            }
            catch {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// Modifie la liste des matchs par celle donnée en argument
        /// </summary>
        /// <param name="matchList">Nouvelle liste de matchs</param>
        /// <returns>Vrai si la mise à jour a bien eu lieu, faux sinon</returns>
        bool IServiceJediTournament.updateMatchs(List<MatchWCF> matchList) {

            bool flag = true;
            List<Match> values = new List<Match>();

            foreach (MatchWCF m in matchList) {
                values.Add(m.convert());
            }

            JediTournamentManager manager = new JediTournamentManager();
            manager.updateMatches(values);

            return flag;
        }

        #endregion Matchs

        List<TournoiWCF> IServiceJediTournament.getTournois() {
            throw new NotImplementedException();
        }
    }
}