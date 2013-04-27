﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GCDataTier.Models;

namespace GCWebSite.Controllers
{
    public class SkillVolunteerController : Controller
    {
        private NEGCContext db = new NEGCContext();

        //
        // GET: /SkillVolunteer/

        public ActionResult Index()
        {
            var skillvolunteers = db.SkillVolunteers.Include(s => s.Skill).Include(s => s.Volunteer);
            return View(skillvolunteers.ToList());
        }

        //
        // GET: /SkillVolunteer/Details/5

        public ActionResult Details(int id = 0)
        {
            SkillVolunteer skillvolunteer = db.SkillVolunteers.Find(id);
            if (skillvolunteer == null)
            {
                return HttpNotFound();
            }
            return View(skillvolunteer);
        }

        //
        // GET: /SkillVolunteer/Create

        public ActionResult Create()
        {
            ViewBag.SkillId = new SelectList(db.Skills, "SkillId", "SkillLevelDescription");
            ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId");
            return View();
        }

        //
        // POST: /SkillVolunteer/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SkillVolunteer skillvolunteer)
        {
            if (ModelState.IsValid)
            {
                db.SkillVolunteers.Add(skillvolunteer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SkillId = new SelectList(db.Skills, "SkillId", "SkillLevelDescription", skillvolunteer.SkillId);
            ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId", skillvolunteer.VolunteerId);
            return View(skillvolunteer);
        }

        //
        // GET: /SkillVolunteer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SkillVolunteer skillvolunteer = db.SkillVolunteers.Find(id);
            if (skillvolunteer == null)
            {
                return HttpNotFound();
            }
            ViewBag.SkillId = new SelectList(db.Skills, "SkillId", "SkillLevelDescription", skillvolunteer.SkillId);
            ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId", skillvolunteer.VolunteerId);
            return View(skillvolunteer);
        }

        //
        // POST: /SkillVolunteer/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SkillVolunteer skillvolunteer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skillvolunteer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SkillId = new SelectList(db.Skills, "SkillId", "SkillLevelDescription", skillvolunteer.SkillId);
            ViewBag.VolunteerId = new SelectList(db.Volunteers, "VolunteerId", "SignUpPartyId", skillvolunteer.VolunteerId);
            return View(skillvolunteer);
        }

        //
        // GET: /SkillVolunteer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SkillVolunteer skillvolunteer = db.SkillVolunteers.Find(id);
            if (skillvolunteer == null)
            {
                return HttpNotFound();
            }
            return View(skillvolunteer);
        }

        //
        // POST: /SkillVolunteer/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SkillVolunteer skillvolunteer = db.SkillVolunteers.Find(id);
            db.SkillVolunteers.Remove(skillvolunteer);
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