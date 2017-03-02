using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTest.Controllers
{
    public class AdministradorController : Controller
    {
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
            return View("../Convocatoria/Create");
        }
        public ActionResult asignarModulo()
        {
            return View("../Convocatoria/Create");
        }
        public ActionResult reporteModulos()
        {
            return View("../Reportes/calificacionesModulos");
        }
    }
}