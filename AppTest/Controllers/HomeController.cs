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
using System.Data.SqlClient;

namespace AppTest.Controllers
{
    public class HomeController : Controller
    {

        private DatabaseEspamEntities db = new DatabaseEspamEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Inicio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(string usuario, string password)
        {

            var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DatabaseEspam;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True");
            var cmd = new SqlCommand("GetEstudianteFromMatricula", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@matri", usuario);
            
            connection.Open();
           
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    //System.Diagnostics.Debug.WriteLine(usuario.Length);
                    
                    string valMatricula= reader.GetValue(4).ToString().Replace(" ", String.Empty);
                    string valPassword = reader.GetValue(6).ToString().Replace(" ", String.Empty);

                    if (usuario.Equals(valMatricula) & password.Equals(valPassword))
                    {
                        Session["nombres"] = reader.GetValue(0);
                        Session["apellidos"] = reader.GetValue(1);
                        Session["carrera"] = reader.GetValue(2);
                        Session["cedula"] = reader.GetValue(3);
                        Session["matricula"] = reader.GetValue(4);
                        Session["genero"] = reader.GetValue(5);
                        connection.Close();
                        return Redirect("../Estudiante");
                    }
                    else 
                    {
                        connection.Close();
                        TempData["msg"] = "<script>alert('Contraseña Incorrecta.');</script>";
                        return View("Index");
                    }
                }
                else if(usuario == "admin")
                    {
                    Session["nombres"] = "Administrador";
                    Session["apellidos"] = "";
                    connection.Close();
                    return Redirect("../Administrador");
                }
                    else
                {
                    connection.Close();
                    TempData["msg"] = "<script>alert('Usuario no se encuentra en la base de datos.');</script>";
                    return View("Index");
                }
            }
           
        }


    }
}