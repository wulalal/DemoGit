using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBundle.Controllers.Admin.A1
{
    public class UserCusController : Controller
    {
        //
        // GET: /UserCus/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /UserCus/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /UserCus/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UserCus/Create

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
        // GET: /UserCus/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /UserCus/Edit/5

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
        // GET: /UserCus/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /UserCus/Delete/5

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
