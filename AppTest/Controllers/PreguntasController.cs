﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppTest.Models;

namespace AppTest.Controllers
{
    public class PreguntasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Preguntas
        public ActionResult Index()
        {
            return View(db.Preguntas.ToList());
        }

        // GET: Preguntas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pregunta pregunta = db.Preguntas.Find(id);
            if (pregunta == null)
            {
                return HttpNotFound();
            }
            return View(pregunta);
        }

        // GET: Preguntas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Preguntas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "preguntaID,textoPregunta")] Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                db.Preguntas.Add(pregunta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pregunta);
        }

        // GET: Preguntas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pregunta pregunta = db.Preguntas.Find(id);
            if (pregunta == null)
            {
                return HttpNotFound();
            }
            return View(pregunta);
        }

        // POST: Preguntas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "preguntaID,textoPregunta")] Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pregunta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pregunta);
        }

        // GET: Preguntas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pregunta pregunta = db.Preguntas.Find(id);
            if (pregunta == null)
            {
                return HttpNotFound();
            }
            return View(pregunta);
        }

        // POST: Preguntas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pregunta pregunta = db.Preguntas.Find(id);
            db.Preguntas.Remove(pregunta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
