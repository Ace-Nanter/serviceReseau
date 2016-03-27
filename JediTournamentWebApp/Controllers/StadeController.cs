using JediTournamentWebApp.JediTournamentWCF;
using JediTournamentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediTournamentWebApp.Controllers
{
    public class StadeController : Controller
    { 
        #region Index
        // GET: Stade
        public ActionResult Index() {
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<StadeWCF> webList = client.getStades();
                    List<StadeWebModel> localList = new List<StadeWebModel>();

                    foreach (StadeWCF s in webList) {
                        localList.Add(new StadeWebModel(s));
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
        
        #endregion

        #region Creation
        // GET: Stade/Create
        public ActionResult Create() {
            return PartialView(new StadeWebModel());
        }

        // POST: Stade/Create
        [HttpPost]
        public ActionResult Create(StadeWebModel stade, int[] caracIds) {
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

                        // Ajout du StadeWCF
                        stade.Caracteristiques = caracList;
                        client.newStade(stade.convert());

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
                        // Si c'est une caractéristique de Stade
                        if (c.Type != 0) {
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
        // GET: Stade/Edit/5
        public ActionResult Edit(int id) {
            StadeWebModel item = null;
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<StadeWCF> webList = client.getStades();

                    foreach (StadeWCF s in webList) {
                        if (s.Id == id) {
                            item = new StadeWebModel(s);
                            break;
                        }
                    }

                    if (TempData["error"] != null) {
                        ViewData["error"] = TempData["error"];
                    }
                    else {
                        ViewData["error"] = null;
                    }

                    // Si on ne trouve pas le Stade
                    if (item == null) {
                        throw new Exception("No way to found the stade !");
                    }

                    return PartialView(item);
                }
            }
            catch {
                return null;
            }
        }

        // POST: Stade/Edit/5
        [HttpPost]
        public ActionResult Edit(StadeWebModel stade, int[] caracIds) {

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
                        stade.Caracteristiques = caracList;

                        // Recherche du stade et mise à jour
                        List<StadeWCF> list = client.getStades();
                        for (int i = 0; i < list.Count; i++) {
                            if (list[i].Id == stade.Id) {
                                list[i] = stade.convert();
                                break;
                            }
                        }

                        client.updateStades(list);
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

        #region Suppression

        // POST: Stade/Delete/5
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
                        client.removeStades(id);
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