using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTest.Models
{
    public class Convocatoria
    {
        public int convocatoriaID { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public Boolean cActiva { get; set;}
        public string descripcion { get; set; }
        public Test testAptitudes { get; set; }
        public Test testConocimiento { get; set; }
        public LinkedList<Usuario> estudiantes { get; set; }
        public LinkedList<Usuario> profesores { get; set; }
    }
}