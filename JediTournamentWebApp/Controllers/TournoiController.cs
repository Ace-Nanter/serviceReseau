using JediTournamentWebApp.JediTournamentWCF;
using JediTournamentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediTournamentWebApp.Controllers
{
    public class TournoiController : Controller
    {
        // GET: Tournoi
        public ActionResult Index()
        {
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<TournoiWCF> webList = client.getTournois();
                    List<TournoiWebModel> localList = new List<TournoiWebModel>();

                    foreach (TournoiWCF t in webList) {
                        localList.Add(new TournoiWebModel(t));
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

        // POST: Tournament/Launch/5
        [HttpPost, ActionName("Launch")]
        public ActionResult Launch(int idTournoi) {
            if (ModelState.IsValid) {
                try {
                    using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {


                        client.launchTournoi(idTournoi);
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
    }
}
