using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetLearning.Controllers
{
    public class ERWAController : Controller   // Empty empty read/write action
    {
        //
        // GET: /ERWA/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ERWA/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ERWA/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ERWA/Create

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
        // GET: /ERWA/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ERWA/Edit/5

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
        // GET: /ERWA/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ERWA/Delete/5

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
