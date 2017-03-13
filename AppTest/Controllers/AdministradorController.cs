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
    public class AdministradorController : Controller
    {

        private DatabaseEspamEntities db = new DatabaseEspamEntities();
        // GET: Administrador
        public ActionResult Index()
        {
            return View("crearConvocatoria");
        }
        public ActionResult nuevaConvocatoria()
        {
            return View("crearConvocatoria");
        }
        public ActionResult nuevoTestAptitudes()
        {
            return View("crearTestAptitudes");
        }
        public ActionResult nuevoTestPostulacion()
        {
            return View("crearTestPostulacion");
        }
        public ActionResult reporteConvocatorias()
        {
            return View("../Reportes/calificacionesAptitudes");
        }
        public ActionResult nuevoDocente()
        {
            return View();
        }
        public ActionResult nuevoCoordinador()
        {
            return View("../Convocatoria/Create");
        }
        public ActionResult nuevoModulo()
        {
            return View();
        }
        public ActionResult asignarModulo()
        {
            return View("../Convocatoria/Create");
        }
        public ActionResult reporteModulos()
        {
            return View("../Reportes/calificacionesModulos");
        }

        [HttpPost]
        public ActionResult crearModulo(string nombre, string descripcion)

        {
            db.CrearModulo(nombre, descripcion);
            return View("nuevoModulo");
        }

        [HttpPost]
        public ActionResult crearTestAptitudes(String [] pregunta)

        {
            db.AgregarPreguntaATest(1,pregunta[0],pregunta[1],pregunta[2], pregunta[3], pregunta[4], Int32.Parse(pregunta[5]));
            return View("nuevoModulo");
        }

        [HttpPost]
        public ActionResult crearTestPostulacion(String[] pregunta)

        {
            db.AgregarPreguntaATest(2, pregunta[0], pregunta[1], pregunta[2], pregunta[3], pregunta[4], Int32.Parse(pregunta[5]));
            return View("nuevoModulo");
        }

        [HttpPost]
        public ActionResult crearConvocatoria(DateTime finicio, DateTime ffinal, String descripcion)

        {
            db.CrearConvocatoria(finicio,ffinal,descripcion);
            return View("crearConvocatoria");
        }

        [HttpPost]
        public ActionResult nuevoDocente(string nombres, string apellidos, string genero, string area, string carrera, string usuario, string contrasena, string contrasenaVerificar)

        {
            if (contrasena == contrasenaVerificar)
            {
                db.AgregarDocente(nombres, apellidos, usuario, contrasena, genero, area, carrera);
                return View("nuevoDocente");

            }
            return View("nuevoDocente");
        }
        [HttpPost]
        public ActionResult nuevoCoordinador(string nombre, string descripcion)

        {
            db.CrearModulo(nombre, descripcion);
            return View("nuevoModulo");
        }
        [HttpPost]
        public ActionResult cerrarSesion()

        {
            Session.Clear();
            return Redirect("../Home/Index");
        }

    }
}