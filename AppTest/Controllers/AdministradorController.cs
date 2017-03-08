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
            return View("../Convocatoria/Create");
        }
        public ActionResult nuevaConvocatoria()
        {
            return View("../Convocatoria/Create");
        }
        public ActionResult nuevoTestAptitudes()
        {
            return View("../Test/Create");
        }
        public ActionResult nuevoTestPostulacion()
        {
            return View("../Test/Create");
        }
        public ActionResult reporteConvocatorias()
        {
            return View("../Reportes/calificacionesAptitudes");
        }
        public ActionResult nuevoDocente()
        {
            return View("../Convocatoria/Create");
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

    }
}