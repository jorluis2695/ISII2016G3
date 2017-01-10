using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Vista
{
    public partial class postulacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseEspam;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "GetTest";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                try
                {
                    TestEspacio.InnerHtml = "<div class=\"form-group\" > < label class=\"col-sm-2 control-label\" >"+ reader.GetString(0) +"</label> < div class=\"col-sm-10\"> <div class=\"radio\"><label> <input type=\"radio\" name =\"optionsRadios\" id =\"optionsRadios1\" value =\"\" checked>"+ reader.GetString(1) +"</label></div><div class=\"radio\"><label><input type=\"radio\" name =\"optionsRadios\" id =\"optionsRadios2\" value =\"\">" + reader.GetString(2) + "</label></div><div class=\"radio\"> <label><input type=\"radio\" name =\"optionsRadios\" id =\"optionsRadios3\" value =\"\" >" + reader.GetString(3) + "</label> </div><div class=\"radio\"> <label><input type=\"radio\" name =\"optionsRadios\" id =\"optionsRadios4\" value =\"\" >" + reader.GetString(4) + " </label> </div></div></div>";
                    con.Close();
                }
                catch
                {
                    string display = "Error";
                    ClientScript.RegisterStartupScript(this.GetType(), "No se encontraron tests dentro de la Base de Datos", "alert('" + display + "');", true);
                }
            }
    }
}