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
    public class ReportesController : Controller
    {


        private DatabaseEspamEntities db = new DatabaseEspamEntities();

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