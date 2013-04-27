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
    public class ContactLinkController : Controller
    {
        private NEGCContext db = new NEGCContext();

        //
        // GET: /ContactLink/

        public ActionResult Index()
        {
            var contactlinks = db.ContactLinks.Include(c => c.Contact).Include(c => c.NPO).Include(c => c.Volunteer);
            return View(contactlinks.ToList());
        }

        //
        // GET: /ContactLink/Details/5

        public ActionResult Details(int id = 0)
        {
            ContactLink contactlink = db.ContactLinks.Find(id);
            if (contactlink == null)
            {
                return HttpNotFound();
            }
            return View(contactlink);
        }

        //
        // GET: /ContactLink/Create

        public ActionResult Create()
        {
            ViewBag.ContactId = new SelectList(db.Contacts, "ContactId", "Email");
            ViewBag.NPOId = new SelectList(db.NPOes, "NPOID", "Name");
            ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId");
            return View();
        }

        //
        // POST: /ContactLink/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactLink contactlink)
        {
            if (ModelState.IsValid)
            {
                db.ContactLinks.Add(contactlink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContactId = new SelectList(db.Contacts, "ContactId", "Email", contactlink.ContactId);
            ViewBag.NPOId = new SelectList(db.NPOes, "NPOID", "Name", contactlink.NPOId);
            ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId", contactlink.VolunteerId);
            return View(contactlink);
        }

        //
        // GET: /ContactLink/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ContactLink contactlink = db.ContactLinks.Find(id);
            if (contactlink == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactId = new SelectList(db.Contacts, "ContactId", "Email", contactlink.ContactId);
            ViewBag.NPOId = new SelectList(db.NPOes, "NPOID", "Name", contactlink.NPOId);
            ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId", contactlink.VolunteerId);
            return View(contactlink);
        }

        //
        // POST: /ContactLink/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContactLink contactlink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactlink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContactId = new SelectList(db.Contacts, "ContactId", "Email", contactlink.ContactId);
            ViewBag.NPOId = new SelectList(db.NPOes, "NPOID", "Name", contactlink.NPOId);
            ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId", contactlink.VolunteerId);
            return View(contactlink);
        }

        //
        // GET: /ContactLink/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ContactLink contactlink = db.ContactLinks.Find(id);
            if (contactlink == null)
            {
                return HttpNotFound();
            }
            return View(contactlink);
        }

        //
        // POST: /ContactLink/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactLink contactlink = db.ContactLinks.Find(id);
            db.ContactLinks.Remove(contactlink);
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