using JediTournamentWebApp.JediTournamentWCF;
using JediTournamentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediTournamentWebApp.Controllers
{
    public class MatchController : Controller {

        #region Index
        // GET: Match
        public ActionResult Index() {
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<MatchWCF> webList = client.getMatchs();
                    List<MatchWebModel> localList = new List<MatchWebModel>();

                    foreach (MatchWCF m in webList) {
                        localList.Add(new MatchWebModel(m));
                    }

                    if (TempData["error"] != null) {
                        ViewData["error"] = TempData["error"];
                    }
                    else {
                        ViewData["error"] = null;
                    }

                    return View(localList);
                }
            }
            catch {
                return View();
            }
        }

        // GET: Match/Details/5
        public ActionResult Details(int id) {
            MatchWebModel item = null;
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<MatchWCF> webList = client.getMatchs();

                    foreach (MatchWCF m in webList) {
                        if (m.Id == id) {
                            item = new MatchWebModel(m);
                            break;
                        }
                    }

                    if (TempData["error"] != null) {
                        ViewData["error"] = TempData["error"];
                    }
                    else {
                        ViewData["error"] = null;
                    }

                    // Si on ne trouve pas le Match
                    if (item == null) {
                        throw new Exception("No way to found the match !");
                    }

                    return PartialView(item);
                }
            }
            catch {
                return null;
            }
        }
        #endregion

        #region Creation
        // GET: Match/Create
        public ActionResult Create() {
            return PartialView(new MatchWebModel());
        }
        #endregion

        /*
        // POST: Match/Create
        [HttpPost]
        public ActionResult Create(MatchWebModel match) {
            if (ModelState.IsValid) {
                try {
                    using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {

                        // Récupération caractéristiques si nécessaire
                        if (caracIds != null && caracIds.Length > 0) {
                            List<CaracteristiqueWCF> webList = client.getCaracs();

                            // Pour chaque caractéristique voulue
                            foreach (int id in caracIds) {
                                // On cherche la caractéristique correspondante
                                foreach (CaracteristiqueWCF c in webList) {
                                    if (c.Id == id) {
                                        caracList.Add(new CaracWebModel(c));
                                        break;
                                    }
                                }
                            }
                        }
                        List<MatchWCF> list = client.getMatchs();

                        // Création du MatchWCF
                        jedi.Caracteristiques = caracList;
                        client.newJedi(jedi.convert());

                        client.Close();
                    }
                }
                catch {
                    TempData["error"] = "Adding error !";
                }
            }
            else {
                TempData["error"] = "Invalid Model !";
            }

            return RedirectToAction("Index");
        }

        public ActionResult AddCarac() {
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<CaracteristiqueWCF> webList = client.getCaracs();
                    List<CaracWebModel> localList = new List<CaracWebModel>();

                    foreach (CaracteristiqueWCF c in webList) {
                        // Si c'est une caractéristique de Jedi
                        if (c.Type == 0) {
                            localList.Add(new CaracWebModel(c));
                        }
                    }

                    if (TempData["error"] != null) {
                        ViewData["error"] = TempData["error"];
                    }
                    else {
                        ViewData["error"] = null;
                    }

                    return PartialView(localList);
                }
            }
            catch {
                return null;
            }
        }
        #endregion

        #region Edition
        // GET: Jedi/Edit/5
        public ActionResult Edit(int id) {
            MatchWebModel item = null;
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<MatchWCF> webList = client.getMatchs();

                    foreach (MatchWCF j in webList) {
                        if (j.Id == id) {
                            item = new MatchWebModel(j);
                            break;
                        }
                    }

                    if (TempData["error"] != null) {
                        ViewData["error"] = TempData["error"];
                    }
                    else {
                        ViewData["error"] = null;
                    }

                    // Si on ne trouve pas le Jedi
                    if (item == null) {
                        throw new Exception("No way to found the jedi !");
                    }

                    return PartialView(item);
                }
            }
            catch {
                return null;
            }
            return View();
        }

        // POST: Jedi/Edit/5
        [HttpPost]
        public ActionResult Edit(MatchWebModel jedi, int[] caracIds) {

            if (ModelState.IsValid) {
                try {
                    using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {

                        List<CaracWebModel> caracList = new List<CaracWebModel>();
                        // Récupération caractéristiques si nécessaire
                        if (caracIds != null && caracIds.Length > 0) {
                            List<CaracteristiqueWCF> webList = client.getCaracs();

                            // Pour chaque caractéristique voulue
                            foreach (int id in caracIds) {
                                // On cherche la caractéristique correspondante
                                foreach (CaracteristiqueWCF c in webList) {
                                    if (c.Id == id) {
                                        caracList.Add(new CaracWebModel(c));
                                        break;
                                    }
                                }
                            }
                        }

                        // Ajout des caractéristiques
                        jedi.Caracteristiques = caracList;

                        // Recherche du jedi et mise à jour
                        List<MatchWCF> list = client.getMatchs();
                        for (int i = 0; i < list.Count; i++) {
                            if (list[i].Id == jedi.Id) {
                                list[i] = jedi.convert();
                                break;
                            }
                        }

                        client.updateMatchs(list);
                        client.Close();
                    }
                }
                catch {
                    TempData["error"] = "Adding error !";
                }
            }
            else {
                TempData["error"] = "Invalid Model !";
            }

            return RedirectToAction("Index");
        }
        #endregion
        */

        #region Suppression
        // POST: Match/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(string[] deleteInputs) {

            List<int> id = null;
            #region Conversion en int
            if (deleteInputs != null) {
                id = new List<int>();
                int tmp;

                foreach (string i in deleteInputs) {
                    int.TryParse(i, out tmp);
                    id.Add(tmp);
                }
            }
            #endregion

            if (id != null && id.Count > 0) {
                try {
                    using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                        client.removeMatch(id);
                    }
                    return RedirectToAction("Index");
                }
                catch {
                    TempData["error"] = "Delete error !";
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
        #endregion
    }
}