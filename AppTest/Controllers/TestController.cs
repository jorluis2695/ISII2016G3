using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppTest.Models;

namespace AppTest.Controllers
{
    public class TestController : Controller
    {
        private AppTestContext db = new AppTestContext();

        // GET: Test
        public async Task<ActionResult> Index()
        {
            return View(await db.Tests.ToListAsync());
        }

        // GET: Test/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test test = await db.Tests.FindAsync(id);
            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "testID,tipo,nombreTest")] Test test)
        {
            if (ModelState.IsValid)
            {
                db.Tests.Add(test);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(test);
        }

        // GET: Test/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test test = await db.Tests.FindAsync(id);
            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // POST: Test/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "testID,tipo,nombreTest")] Test test)
        {
            if (ModelState.IsValid)
            {
                db.Entry(test).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(test);
        }

        // GET: Test/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test test = await db.Tests.FindAsync(id);
            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // POST: Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Test test = await db.Tests.FindAsync(id);
            db.Tests.Remove(test);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ActionName("AgregarPreguntaTest")]
        
        public async Task<ActionResult> AgregarPreguntaTest(int idT, int id)
        {
            //int idTest = int.Parse(Request.Url.Segments.Last().Split('?')[0]);
            Testpregunta tp1 = new Testpregunta();
            tp1.IdPregunta = id;
            tp1.IdTest = idT;
            db.Testpreguntas.Add(tp1);
            await db.SaveChangesAsync();
            return View(await db.Preguntas.ToListAsync());
        }

        public async Task<ActionResult> AgregarPregunta(int id)
        {
           return View(await db.Preguntas.ToListAsync());
        }

        public ActionResult TomarTest()
        {
            Random rnd = new Random();
            List<Testpregunta> tR = db.Testpreguntas.Where(t => t.IdTest.Equals(1)).ToList();
            LinkedList<Pregunta> aP = new LinkedList<Pregunta>();
            foreach (Testpregunta t in tR)
            {
                Pregunta pU = (Pregunta)db.Preguntas.Where(p => p.preguntaID.Equals(t.IdPregunta)).First();
                aP.AddLast(pU);
            }
            return View(aP);
        }
        [HttpPost]
        [ActionName("TomarTest")]
        public ActionResult TomarTest(FormCollection fc)
        {
            String[] k = fc.AllKeys;
            for(int i=0; i < k.Length; i++)
            {
                int a = int.Parse(fc.GetValue(k[i]).ToString() );
                tp=db.Testpreguntas.Where(p=>p.)
            }
            

            return View();
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
