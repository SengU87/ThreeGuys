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
    public class NPOProjectController : Controller
    {
        private NEGCContext db = new NEGCContext();

        //
        // GET: /NPOProject/

        public ActionResult Index()
        {
            var npoprojects = db.NPOProjects.Include(n => n.NPO).Include(n => n.Project);
            return View(npoprojects.ToList());
        }

        //
        // GET: /NPOProject/Details/5

        public ActionResult Details(int id = 0)
        {
            NPOProject npoproject = db.NPOProjects.Find(id);
            if (npoproject == null)
            {
                return HttpNotFound();
            }
            return View(npoproject);
        }

        //
        // GET: /NPOProject/Create

        public ActionResult Create()
        {
            ViewBag.NPOId = new SelectList(db.NPOes, "NPOID", "Name");
            //ViewBag.ProjectID = new SelectList(db.Projects, "ProjectId", "Name");
            return View();
        }

        //
        // POST: /NPOProject/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NPOProject npoproject)
        {
            if (ModelState.IsValid)
            {
                db.NPOProjects.Add(npoproject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NPOId = new SelectList(db.NPOes, "NPOID", "Name", npoproject.NPOId);
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectId", "Type", npoproject.ProjectID);
            return View(npoproject);
        }

        //
        // GET: /NPOProject/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NPOProject npoproject = db.NPOProjects.Find(id);
            if (npoproject == null)
            {
                return HttpNotFound();
            }
            ViewBag.NPOId = new SelectList(db.NPOes, "NPOID", "Name", npoproject.NPOId);
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectId", "Type", npoproject.ProjectID);
            return View(npoproject);
        }

        //
        // POST: /NPOProject/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NPOProject npoproject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(npoproject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NPOId = new SelectList(db.NPOes, "NPOID", "Name", npoproject.NPOId);
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectId", "Type", npoproject.ProjectID);
            return View(npoproject);
        }

        //
        // GET: /NPOProject/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NPOProject npoproject = db.NPOProjects.Find(id);
            if (npoproject == null)
            {
                return HttpNotFound();
            }
            return View(npoproject);
        }

        //
        // POST: /NPOProject/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NPOProject npoproject = db.NPOProjects.Find(id);
            db.NPOProjects.Remove(npoproject);
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