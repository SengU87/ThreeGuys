using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GCDataTier.Models;

namespace GCWebSite.Controllers
{
    public class VolunteerController : Controller
    {
        private NEGCContext db = new NEGCContext();

        //
        // GET: /Volunteer/

        public ActionResult Index()
        {
            return View(db.Volunteers.ToList());
        }

        //
        // GET: /Volunteer/Details/5

        public ActionResult Details(int id = 0)
        {
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            return View(volunteer);
        }

        //
        // GET: /Volunteer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Volunteer/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                db.Volunteers.Add(volunteer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(volunteer);
        }

        //
        // GET: /Volunteer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            return View(volunteer);
        }

        //
        // POST: /Volunteer/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(volunteer);
        }

        //
        // GET: /Volunteer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            return View(volunteer);
        }

        //
        // POST: /Volunteer/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Volunteer volunteer = db.Volunteers.Find(id);
            db.Volunteers.Remove(volunteer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}