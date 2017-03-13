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
        public ActionResult calificacionesPostulacion()
        {

            return View();

        }
        public ActionResult calificacionesAptitudes()
        {

            return View();

        }
        public ActionResult Informacion()
        {

            return View("Index");

        }
        public ActionResult calificacionesModulos()
        {

            return View();

        }
        public ActionResult TestAptitudes()
        {
            return View(db.GetTest(1).ToList());

        }
        public ActionResult TestPostulacion()
        {
            return View(db.GetTest(2).ToList());

        }

        [HttpPost]
        public ActionResult enviarExamen(String[] pregunta)

        {
            db.AgregarPreguntaATest(1, pregunta[0], pregunta[1], pregunta[2], pregunta[3], pregunta[4], Int32.Parse(pregunta[5]));
            return View("nuevoModulo");
        }
        [HttpPost]
        public ActionResult cerrarSesion()

        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public ActionResult obtenerRespuestasPostulacion(int [] respuestas)

        {
            Session["aciertosPostulacion"] = respuestas[0];
            Session["fallasPostulacion"] = respuestas[1];
            return View("calificacionesPostulacion");
        }
        [HttpPost]
        public ActionResult obtenerRespuestasAptitudes(int[] respuestas)

        {
            Session["aciertosAptitudes"] = respuestas[0];
            Session["fallasAptitudes"] = respuestas[1];
            return View("calificacionesAptitudes");
        }
    }
}