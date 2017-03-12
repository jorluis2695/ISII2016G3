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
    public class EstudianteController : Controller
    {

        private DatabaseEspamEntities db = new DatabaseEspamEntities();

        // GET: Estudiante
        public ActionResult Index()
        {
            
            return View();
        
        }
        public ActionResult Informacion()
        {

            return View("Index");

        }
        public ActionResult TestAptitudes()
        {
            return View(db.GetTest(1).ToList());

        }
        public ActionResult TestPostulacion()
        {
            return View(db.GetTest(2).ToList());

        }
    }
}