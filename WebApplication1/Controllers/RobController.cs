﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RobController : Controller
    {
        // GET: Rob
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rob/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rob/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rob/Create
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

        // GET: Rob/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rob/Edit/5
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

        // GET: Rob/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rob/Delete/5
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
