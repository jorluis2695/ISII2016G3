using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTest.Models

{
    public class Pregunta
    {
        public int preguntaID { get; set; }
        public string textoPregunta { get; set; }
        public string op1 { get; set; }
        public string op2 { get; set; }
        public string op3 { get; set; }
        public string op4 { get; set; }
        public int opCorrecta { get; set; }
    }
}