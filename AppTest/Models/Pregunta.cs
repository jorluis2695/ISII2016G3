using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTest.Models

{
    public class Pregunta
    {
        public int preguntaID { get; set; }
        public string textoPregunta { get; set; }
        public List<string> respuestas { get; set; }
        public Rubrica rubricaPregunta{ get; set; }
    }
}