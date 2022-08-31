using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadmeDT.Models;
using System.Data;
using System.Data.Entity.Validation;

namespace CadmeDT.Controllers
{
    public class Usados041S1Controller : Controller
    {
        // GET: Usados041S1
        public ActionResult Index()
        {
            List<usados041> usados041 = new List<usados041>();
            using (cadmeEntities cadme = new cadmeEntities())
            {
                usados041 = cadme.usados041.ToList();
            }
            return View(usados041);
        }

        // GET: Usados041S1/Details/5
        public ActionResult Details(int id)
        {
            usados041 usados041 = new usados041();
            using (cadmeEntities cadme = new cadmeEntities())
            {
                usados041 = cadme.usados041.Where(x => x.id == id).FirstOrDefault();
            }

            return View(usados041);
        }

        // GET: Usados041S1/Create
        public ActionResult Create()
        {
            return View(new usados041());
        }

        // POST: Usados041S1/Create
        [HttpPost]
        public ActionResult Create(usados041 usados041)
        {
            using (cadmeEntities cadme = new cadmeEntities())
            {
                cadme.usados041.Add(usados041);
                cadme.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Usados041S1/Edit/5
        public ActionResult Edit(int id)
        {
            usados041 usados041 = new usados041();
            using (cadmeEntities cadme = new cadmeEntities())
            {
                usados041 = cadme.usados041.Where(x => x.id == id).FirstOrDefault();
            }

            return View(usados041);
        }

        // POST: Usados041S1/Edit/5
        [HttpPost]
        public ActionResult Edit(usados041 usados041)
        {
            try
            {
                using (cadmeEntities cadme = new cadmeEntities())
                {
                    cadme.Entry(usados041).State = EntityState.Modified;
                    cadme.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {

                Console.WriteLine(e);

            }

            return RedirectToAction("Index");
        }

        // GET: Usados041S1/Delete/5
        public ActionResult Delete(int id)
        {

            usados041 usados041 = new usados041();
            using (cadmeEntities cadme = new cadmeEntities())
            {
                usados041 = cadme.usados041.Where(x => x.id == id).FirstOrDefault();
            }

            return View(usados041);
        }

        // POST: Usados041S1/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            using (cadmeEntities cadme = new cadmeEntities())
            {
                usados041 usados041 = cadme.usados041.Where(x => x.id == id).FirstOrDefault();
                cadme.usados041.Remove(usados041);
                cadme.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
