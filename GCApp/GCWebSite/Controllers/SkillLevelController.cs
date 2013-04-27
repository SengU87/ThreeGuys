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
    public class SkillLevelController : Controller
    {
        private NEGCContext db = new NEGCContext();

        //
        // GET: /SkillLevel/

        public ActionResult Index()
        {
            return View(db.SkillLevels.ToList());
        }

        //
        // GET: /SkillLevel/Details/5

        public ActionResult Details(string id = null)
        {
            SkillLevel skilllevel = db.SkillLevels.Find(id);
            if (skilllevel == null)
            {
                return HttpNotFound();
            }
            return View(skilllevel);
        }

        //
        // GET: /SkillLevel/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SkillLevel/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SkillLevel skilllevel)
        {
            if (ModelState.IsValid)
            {
                db.SkillLevels.Add(skilllevel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skilllevel);
        }

        //
        // GET: /SkillLevel/Edit/5

        public ActionResult Edit(string id = null)
        {
            SkillLevel skilllevel = db.SkillLevels.Find(id);
            if (skilllevel == null)
            {
                return HttpNotFound();
            }
            return View(skilllevel);
        }

        //
        // POST: /SkillLevel/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SkillLevel skilllevel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skilllevel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skilllevel);
        }

        //
        // GET: /SkillLevel/Delete/5

        public ActionResult Delete(string id = null)
        {
            SkillLevel skilllevel = db.SkillLevels.Find(id);
            if (skilllevel == null)
            {
                return HttpNotFound();
            }
            return View(skilllevel);
        }

        //
        // POST: /SkillLevel/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SkillLevel skilllevel = db.SkillLevels.Find(id);
            db.SkillLevels.Remove(skilllevel);
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