using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AppTest.Models
{
    public class TestpreguntasController : Controller
    {
        private AppTestContext db = new AppTestContext();

        // GET: Testpreguntas
        public async Task<ActionResult> Index()
        {
            return View(await db.Testpreguntas.ToListAsync());
        }

        // GET: Testpreguntas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testpregunta testpregunta = await db.Testpreguntas.FindAsync(id);
            if (testpregunta == null)
            {
                return HttpNotFound();
            }
            return View(testpregunta);
        }

        // GET: Testpreguntas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Testpreguntas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "testpreguntaID,IdTest,IdPregunta")] Testpregunta testpregunta)
        {
            if (ModelState.IsValid)
            {
                db.Testpreguntas.Add(testpregunta);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(testpregunta);
        }

        // GET: Testpreguntas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testpregunta testpregunta = await db.Testpreguntas.FindAsync(id);
            if (testpregunta == null)
            {
                return HttpNotFound();
            }
            return View(testpregunta);
        }

        // POST: Testpreguntas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "testpreguntaID,IdTest,IdPregunta")] Testpregunta testpregunta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testpregunta).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(testpregunta);
        }

        // GET: Testpreguntas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testpregunta testpregunta = await db.Testpreguntas.FindAsync(id);
            if (testpregunta == null)
            {
                return HttpNotFound();
            }
            return View(testpregunta);
        }

        // POST: Testpreguntas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Testpregunta testpregunta = await db.Testpreguntas.FindAsync(id);
            db.Testpreguntas.Remove(testpregunta);
            await db.SaveChangesAsync();
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
