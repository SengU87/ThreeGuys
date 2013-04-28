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
    public class ProjectVolunteerController : Controller
    {
        private NEGCContext db = new NEGCContext();

        //
        // GET: /ProjectVolunteer/

        public ActionResult Index()
        {
            var projectvolunteers = db.ProjectVolunteers.Include(p => p.Project).Include(p => p.Volunteer);
            return View(projectvolunteers.ToList());
        }

        //
        // GET: /ProjectVolunteer/Details/5

        public ActionResult Details(int id = 0)
        {
            ProjectVolunteer projectvolunteer = db.ProjectVolunteers.Find(id);
            if (projectvolunteer == null)
            {
                return HttpNotFound();
            }
            return View(projectvolunteer);
        }

        //
        // GET: /ProjectVolunteer/Create

        public ActionResult Create()
        {
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "Type");
            //ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId");
            var volunteers = db.Volunteers.Select(v => new { v.VolunteerId, Name = v.FirstName + " " + v.LastName });

            ViewBag.VolunteerId = new SelectList(volunteers, "VolunteerId", "Name");

            return View();
        }

        //
        // POST: /ProjectVolunteer/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectVolunteer projectvolunteer)
        {
            if (ModelState.IsValid)
            {
                db.ProjectVolunteers.Add(projectvolunteer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "Type", projectvolunteer.ProjectId);
            //ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId", projectvolunteer.VolunteerId);
            var volunteers = db.Volunteers.Select(v => new { v.VolunteerId, Name = v.FirstName + " " + v.LastName });

            ViewBag.VolunteerId = new SelectList(volunteers, "VolunteerId", "Name");
            return View(projectvolunteer);
        }

        //
        // GET: /ProjectVolunteer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ProjectVolunteer projectvolunteer = db.ProjectVolunteers.Find(id);
            if (projectvolunteer == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "Type", projectvolunteer.ProjectId);
            //ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId", projectvolunteer.VolunteerId);

            var volunteers = db.Volunteers.Select(v => new { v.VolunteerId, Name = v.FirstName + " " + v.LastName });
            ViewBag.VolunteerId = new SelectList(volunteers, "VolunteerId", "Name", projectvolunteer.VolunteerId);
            
            return View(projectvolunteer);
        }

        //
        // POST: /ProjectVolunteer/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjectVolunteer projectvolunteer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectvolunteer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "Type", projectvolunteer.ProjectId);
            ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId", projectvolunteer.VolunteerId);
            return View(projectvolunteer);
        }

        //
        // GET: /ProjectVolunteer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ProjectVolunteer projectvolunteer = db.ProjectVolunteers.Find(id);
            if (projectvolunteer == null)
            {
                return HttpNotFound();
            }
            return View(projectvolunteer);
        }

        //
        // POST: /ProjectVolunteer/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectVolunteer projectvolunteer = db.ProjectVolunteers.Find(id);
            db.ProjectVolunteers.Remove(projectvolunteer);
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