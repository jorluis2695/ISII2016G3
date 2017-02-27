using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using AppTest.Models;

namespace AppTest.Controllers
{
    public class ConvocatoriaController : Controller
    {
        private AppTestContext db = new AppTestContext();

        // GET: Convocatoria
        public async Task<ActionResult> Index()
        {
            return View(await db.Convocatorias.ToListAsync());
        }

        // GET: Convocatoria/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Convocatoria convocatoria = await db.Convocatorias.FindAsync(id);
            if (convocatoria == null)
            {
                return HttpNotFound();
            }
            return View(convocatoria);
        }

        // GET: Convocatoria/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Crear()
        {
            return View();
        }


        // POST: Convocatoria/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "convocatoriaID,fechaInicio,fechaFin,cActiva,descripcion")] Convocatoria convocatoria)
        {
            if (ModelState.IsValid)
            {
                db.Convocatorias.Add(convocatoria);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(convocatoria);
        }

        // GET: Convocatoria/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Convocatoria convocatoria = await db.Convocatorias.FindAsync(id);
            if (convocatoria == null)
            {
                return HttpNotFound();
            }
            return View(convocatoria);
        }

        // POST: Convocatoria/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "convocatoriaID,fechaInicio,fechaFin,cActiva,descripcion")] Convocatoria convocatoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(convocatoria).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(convocatoria);
        }

        // GET: Convocatoria/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Convocatoria convocatoria = await db.Convocatorias.FindAsync(id);
            if (convocatoria == null)
            {
                return HttpNotFound();
            }
            return View(convocatoria);
        }

        // POST: Convocatoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Convocatoria convocatoria = await db.Convocatorias.FindAsync(id);
            db.Convocatorias.Remove(convocatoria);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> ResultadosEvaluacion(int id)
        {
            Convocatoria c = await db.Convocatorias.FindAsync(id);
            return View(c);
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
