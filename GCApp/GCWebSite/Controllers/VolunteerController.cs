using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GCDataTier.Models;
using System.Reflection;

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

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase fUpload)
        {
            OleDbConnection objConn = null;
            OleDbCommand objCmd = null;
            OleDbDataAdapter objAdapter = null;
            DataSet ds = null;
            if (fUpload != null)
            {
                try
                {
                    string sPath = System.IO.Path.Combine(Server.MapPath("~/Downloads"), System.IO.Path.GetFileName(fUpload.FileName));
                    fUpload.SaveAs(sPath);
                    ViewBag.Message = "File upload Successful!";

                    // EXCEL IMPORT
                    //string sConn = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + sPath + "; Extended Properties=Excel 8.0;";
                    //using (objConn = new System.Data.OleDb.OleDbConnection(sConn))
                    //{
                    //    objConn.Open();
                    //    objCmd = new OleDbCommand("Select * From [My Attendees$]", objConn);
                    //    objAdapter = new OleDbDataAdapter(objCmd);
                    //    ds = new DataSet("Attendees");
                    //    objAdapter.Fill(ds);
                    //    objConn.Close();
                    //}

                    // CSV OR PLAIN TEXT IMPORT
                    //string sLine = string.Empty;
                    //System.IO.StreamReader sReader = new System.IO.StreamReader(sPath);

                    //while ((sLine = sReader.ReadLine()) != null)
                    //{
                    //    //Response.Write(sLine);
                    //}
                    //sReader.Close();
                    //sReader = null;

                    //CSV IMPORT USING OLEDB FOR DATASET
                    string sConn = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + Server.MapPath("~/Downloads") + "; Extended Properties=text;";
                    using (objConn = new System.Data.OleDb.OleDbConnection(sConn))
                    {
                        objConn.Open();
                        objCmd = new OleDbCommand("Select * From [" + System.IO.Path.GetFileName(fUpload.FileName) + "]", objConn);
                        objAdapter = new OleDbDataAdapter(objCmd);
                        ds = new DataSet("Attendees");
                        objAdapter.Fill(ds);
                        objConn.Close();
                    }

                    //GCBLL.VolunteerImport objVolunteer = new GCBLL.VolunteerImport();
                    //objVolunteer.ImportVolunteerInformation(ds);

                    foreach (DataRow dRow in ds.Tables[0].Rows)
                    {
                        Volunteer objVol = new Volunteer();
                        objVol.FirstName = dRow["First name"].ToString();
                        objVol.LastName = dRow["Last name"].ToString();
                        objVol.SignUpPartyId = dRow["Attendee #"].ToString();
                        if (dRow["Date"] != null) objVol.SignUpDate = (Convert.ToDateTime(dRow["Date"]));

                        Contact objContact = new Contact();
                        objContact.Email = dRow["Email"].ToString();
                        objContact.PhoneNumber = dRow["Cell Phone"].ToString();

                        var volResult = db.Volunteers.Add(objVol);
                        var contactResult = db.Contacts.Add(objContact);

                        ContactLink obj = new ContactLink()
                        {
                            Volunteer = volResult,
                            Contact = contactResult
                        };
                        db.SaveChanges();


                    }

                }
                catch (Exception ex)
                {
                    ViewBag.Message = ex.Message;
                }
                finally
                {
                    //if ((objConn != null))
                    //{
                    //    objConn.Close();
                    //}
                }
            }
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