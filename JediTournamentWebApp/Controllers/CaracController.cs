using JediTournamentWebApp.JediTournamentWCF;
using JediTournamentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediTournamentWebApp.Controllers
{
    public class CaracController : Controller
    {
        // GET: Carac
        public ActionResult Index() {
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<CaracteristiqueWCF> webList = client.getCaracs();
                    List<CaracWebModel> localList = new List<CaracWebModel>();

                    foreach (CaracteristiqueWCF c in webList) {
                        localList.Add(new CaracWebModel(c));
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
       
        // GET: Carac/Create
        public ActionResult Create()
        {
            return PartialView(new CaracWebModel());
        }

        // POST: Carac/Create
        [HttpPost]
        public ActionResult Create(CaracWebModel carac)
        {
            if (ModelState.IsValid) {
                try {
                    using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                        client.newCarac(carac.convert(0));
                        client.Close();
                    }
                }
                catch {
                    TempData["error"] = "Adding error !";
                }
            }

            return RedirectToAction("Index");
        }

        // GET: Carac/Edit/5
        public ActionResult Edit(int id)
        {
            CaracWebModel item = null;
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<CaracteristiqueWCF> webList = client.getCaracs();

                    foreach (CaracteristiqueWCF c in webList) {
                        if(c.Id == id) {
                            item = new CaracWebModel(c);
                            break;
                        }
                    }

                    if (TempData["error"] != null) {
                        ViewData["error"] = TempData["error"];
                    }
                    else {
                        ViewData["error"] = null;
                    }

                    // Si on ne trouve pas la caractéristique
                    if(item == null) {
                        throw new Exception("No way to found the characteristic !");
                    }

                    return PartialView(item);
                }
            }
            catch {
                return null;
            }
        }

        // POST: Carac/Edit/5
        [HttpPost]
        public ActionResult Edit(CaracWebModel carac)
        {
            if (ModelState.IsValid) {
                try {
                    using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                        List<CaracteristiqueWCF> list = client.getCaracs();
                        for(int i = 0; i < list.Count; i++) {
                            // On remplace la caractéristique concernée
                            if(list[i].Id == carac.Id) {
                                list[i] = carac.convert(carac.Id);
                                break;
                            }
                        }
                        
                        client.updateCaracs(list);
                        client.Close();
                    }
                }
                catch {
                    TempData["error"] = "Edit error !";
                }
            }

            return RedirectToAction("Index");
        }

        // POST: Carac/Delete/5
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
                        client.removeCarac(id);
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
    }
}
