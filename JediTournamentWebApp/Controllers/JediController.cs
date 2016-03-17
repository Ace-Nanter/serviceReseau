using JediTournamentWebApp.JediTournamentWCF;
using JediTournamentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediTournamentWebApp.Controllers
{
    public class JediController : Controller
    {
        // GET: Jedi
        public ActionResult Index()
        {
            try {
                using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                    List<JediWCF> webList = client.getJedis();
                    List<JediWebModel> localList = new List<JediWebModel>();
                    
                    foreach (JediWCF j in webList) {
                        localList.Add(new JediWebModel(j));
                    }

                    return View(localList);
                }
            }
            catch {
                return View();
            }
            
        }

        // GET: Jedi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jedi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jedi/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jedi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jedi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Jedi/Delete/5
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

            if(id != null && id.Count > 0) {
                try {
                    using (ServiceJediTournamentClient client = new ServiceJediTournamentClient()) {
                        client.removeJedis(id);
                        // TODO : to modify
                    }

                    return RedirectToAction("Index");
                }
                catch {
                    return RedirectToAction("Index");
                    //return Json(new { status = "Success", message = "Success" });
                }
            }
                
            return RedirectToAction("Index");
        }
    }
}
