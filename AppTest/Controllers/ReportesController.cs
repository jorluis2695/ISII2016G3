using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTest.Controllers
{
    public class ReportesController : Controller
    {
        // GET: Reportes
        public ActionResult aprobacionAptitudes()
        {
            return View();
        }
        public ActionResult aprobacionPostulacion()
        {
            return View();
        }
        public ActionResult aprobacionModulos()
        {
            return View();
        }
        public ActionResult calificacionesAptitudes()
        {
            return View();
        }
        public ActionResult calificacionesPostulacion()
        {
            return View();
        }
        public ActionResult calificacionesModulos()
        {
            return View();
        }
    }
}