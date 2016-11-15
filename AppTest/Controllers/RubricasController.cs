using System;
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
    public class RubricasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rubricas
        public ActionResult Index()
        {
            return View(db.Rubricas.ToList());
        }

        // GET: Rubricas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rubrica rubrica = db.Rubricas.Find(id);
            if (rubrica == null)
            {
                return HttpNotFound();
            }
            return View(rubrica);
        }

        // GET: Rubricas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rubricas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rubricaID,textoRubrica,nivelDesarrollo,aporteNota")] Rubrica rubrica)
        {
            if (ModelState.IsValid)
            {
                db.Rubricas.Add(rubrica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rubrica);
        }

        // GET: Rubricas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rubrica rubrica = db.Rubricas.Find(id);
            if (rubrica == null)
            {
                return HttpNotFound();
            }
            return View(rubrica);
        }

        // POST: Rubricas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "rubricaID,textoRubrica,nivelDesarrollo,aporteNota")] Rubrica rubrica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rubrica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rubrica);
        }

        // GET: Rubricas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rubrica rubrica = db.Rubricas.Find(id);
            if (rubrica == null)
            {
                return HttpNotFound();
            }
            return View(rubrica);
        }

        // POST: Rubricas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rubrica rubrica = db.Rubricas.Find(id);
            db.Rubricas.Remove(rubrica);
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
