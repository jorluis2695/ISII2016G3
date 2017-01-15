using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Vista
{
    public partial class postulacion : System.Web.UI.Page
    {
        private IEnumerator result;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DatabaseEspam;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "GetTest";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@TestId", SqlDbType.Int, 50).Value = 1;
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                try
                {
                    result = reader.GetEnumerator();
                    int cont = 0;
                    TestEspacio.InnerHtml = TestEspacio.InnerText + "<form method=\"post\">";
                    do
                    { 
                        TestEspacio.InnerHtml = TestEspacio.InnerText  + "<div id=\"grupo"+cont+"\"> <label class=\"col-sm-2 control-label\">" + reader.GetString(0)  + "</label> <div class=\"col-sm-10\"> <div class=\"radio\"><label> <input type=\"radio\" name =\"grupo"+cont+"\" id =\"optionsRadios1\" value =\"\">" + reader.GetString(1) + "</label></div><div class=\"radio\"><label><input type=\"radio\" name =\"grupo"+cont+"\" id =\"optionsRadios2\" value =\"\">" + reader.GetString(2) + "</label></div><div class=\"radio\"> <label><input type=\"radio\" name =\"grupo"+cont+"\" id =\"optionsRadios3\" value =\"\" >" + reader.GetString(3) + "</label> </div><div class=\"radio\"> <label><input type=\"radio\" name =\"grupo"+cont+"\" id =\"optionsRadios4\" value =\"\" >" + reader.GetString(4) + " </label> </div></div></div>";
                        cont++;
                    } while (result.MoveNext());
                    TestEspacio.InnerHtml = TestEspacio.InnerText + "<div class=\"col-sm-10 pull-right\"><button type = \"submit\" class=\"btn btn-default pull-right\">Enviar Formulario</button></div></form>";

                           con.Close();
                }
                catch
                {
                    string display = "Error: No se encontraron tests dentro de la Base de Datos";
                    ClientScript.RegisterStartupScript(this.GetType(), "No se encontraron tests dentro de la Base de Datos", "alert('" + display + "');", true);
                }


            }
        }
    }
}