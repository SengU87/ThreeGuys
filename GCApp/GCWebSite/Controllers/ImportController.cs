using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GCWebSite.Controllers
{
    public class ImportController : Controller
    {
        //
        // GET: /Import/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Import/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Import/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Import/Create

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

        //
        // GET: /Import/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Import/Edit/5

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

        //
        // GET: /Import/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Import/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
