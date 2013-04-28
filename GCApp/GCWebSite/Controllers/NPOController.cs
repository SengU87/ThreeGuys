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
    public class NPOController : Controller
    {
        private NEGCContext db = new NEGCContext();

        //
        // GET: /NPO/

        public ActionResult Index()
        {
            return View(db.NPOes.ToList());
        }

        //
        // GET: /NPO/Details/5

        public ActionResult Details(int id = 0)
        {
            NPO npo = db.NPOes.Find(id);
            if (npo == null)
            {
                return HttpNotFound();
            }
            return View(npo);
        }

        //
        // GET: /NPO/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NPO/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NPO npo)
        {
            if (ModelState.IsValid)
            {
                db.NPOes.Add(npo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(npo);
        }

        //
        // GET: /NPO/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NPO npo = db.NPOes.Find(id);
            if (npo == null)
            {
                return HttpNotFound();
            }
            return View(npo);
        }

        //
        // POST: /NPO/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NPO npo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(npo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(npo);
        }

        //
        // GET: /NPO/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NPO npo = db.NPOes.Find(id);
            if (npo == null)
            {
                return HttpNotFound();
            }
            return View(npo);
        }

        //
        // POST: /NPO/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NPO npo = db.NPOes.Find(id);
            db.NPOes.Remove(npo);
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