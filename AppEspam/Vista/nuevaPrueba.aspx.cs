using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Vista
{
    public partial class nuevaPrueba : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //Preguntas.InnerHtml = Preguntas.InnerHtml + "HOLA MUNDO";
            string display = "Error: No se encontraron tests dentro de la Base de Datos";
            ClientScript.RegisterStartupScript(this.GetType(), "No se encontraron tests dentro de la Base de Datos", "alert('" + display + "');", true);
        }
        protected void enviarPregunta(object sender, EventArgs e)
        {

            
        }
    }
}