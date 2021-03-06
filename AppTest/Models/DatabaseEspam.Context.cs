﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatabaseEspamEntities : DbContext
    {
        public DatabaseEspamEntities()
            : base("name=DatabaseEspamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Administrador> Administradors { get; set; }
        public virtual DbSet<Convocatoria> Convocatorias { get; set; }
        public virtual DbSet<ConvocatoriaTest> ConvocatoriaTests { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Modulo> Modulos { get; set; }
        public virtual DbSet<Pregunta_estudiante> Pregunta_estudiante { get; set; }
        public virtual DbSet<Pregunta> Preguntas { get; set; }
        public virtual DbSet<Prueba> Pruebas { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TipoTest> TipoTests { get; set; }
        public virtual DbSet<Coordinadore> Coordinadores { get; set; }
        public virtual DbSet<Docente> Docentes { get; set; }
        public virtual DbSet<DocentesModulo> DocentesModulos { get; set; }
    
        public virtual int AgregarPreguntaATest(Nullable<int> idTest, string pregunta, string op1, string op2, string op3, string op4, Nullable<int> opC)
        {
            var idTestParameter = idTest.HasValue ?
                new ObjectParameter("idTest", idTest) :
                new ObjectParameter("idTest", typeof(int));
    
            var preguntaParameter = pregunta != null ?
                new ObjectParameter("pregunta", pregunta) :
                new ObjectParameter("pregunta", typeof(string));
    
            var op1Parameter = op1 != null ?
                new ObjectParameter("op1", op1) :
                new ObjectParameter("op1", typeof(string));
    
            var op2Parameter = op2 != null ?
                new ObjectParameter("op2", op2) :
                new ObjectParameter("op2", typeof(string));
    
            var op3Parameter = op3 != null ?
                new ObjectParameter("op3", op3) :
                new ObjectParameter("op3", typeof(string));
    
            var op4Parameter = op4 != null ?
                new ObjectParameter("op4", op4) :
                new ObjectParameter("op4", typeof(string));
    
            var opCParameter = opC.HasValue ?
                new ObjectParameter("opC", opC) :
                new ObjectParameter("opC", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarPreguntaATest", idTestParameter, preguntaParameter, op1Parameter, op2Parameter, op3Parameter, op4Parameter, opCParameter);
        }
    
        public virtual int AgregarPrerequisitos(Nullable<int> idModulo, Nullable<int> idPrerequisito)
        {
            var idModuloParameter = idModulo.HasValue ?
                new ObjectParameter("idModulo", idModulo) :
                new ObjectParameter("idModulo", typeof(int));
    
            var idPrerequisitoParameter = idPrerequisito.HasValue ?
                new ObjectParameter("idPrerequisito", idPrerequisito) :
                new ObjectParameter("idPrerequisito", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarPrerequisitos", idModuloParameter, idPrerequisitoParameter);
        }
    
        public virtual int CrearConvocatoria(Nullable<System.DateTime> fecha_ini, Nullable<System.DateTime> fecha_fin, string descripcion)
        {
            var fecha_iniParameter = fecha_ini.HasValue ?
                new ObjectParameter("fecha_ini", fecha_ini) :
                new ObjectParameter("fecha_ini", typeof(System.DateTime));
    
            var fecha_finParameter = fecha_fin.HasValue ?
                new ObjectParameter("fecha_fin", fecha_fin) :
                new ObjectParameter("fecha_fin", typeof(System.DateTime));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CrearConvocatoria", fecha_iniParameter, fecha_finParameter, descripcionParameter);
        }
    
        public virtual int CrearConvocatoriaTest(Nullable<int> idConvocatoria, Nullable<int> tipo, Nullable<System.DateTime> fecha, Nullable<int> tiempo)
        {
            var idConvocatoriaParameter = idConvocatoria.HasValue ?
                new ObjectParameter("idConvocatoria", idConvocatoria) :
                new ObjectParameter("idConvocatoria", typeof(int));
    
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var tiempoParameter = tiempo.HasValue ?
                new ObjectParameter("tiempo", tiempo) :
                new ObjectParameter("tiempo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CrearConvocatoriaTest", idConvocatoriaParameter, tipoParameter, fechaParameter, tiempoParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CrearModulo(string nombre, string desc)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CrearModulo", nombreParameter, descParameter);
        }
    
        public virtual int CrearPrueba(Nullable<int> estudianteID, Nullable<int> convocatoriaTestID, Nullable<System.DateTime> fecha)
        {
            var estudianteIDParameter = estudianteID.HasValue ?
                new ObjectParameter("EstudianteID", estudianteID) :
                new ObjectParameter("EstudianteID", typeof(int));
    
            var convocatoriaTestIDParameter = convocatoriaTestID.HasValue ?
                new ObjectParameter("ConvocatoriaTestID", convocatoriaTestID) :
                new ObjectParameter("ConvocatoriaTestID", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CrearPrueba", estudianteIDParameter, convocatoriaTestIDParameter, fechaParameter);
        }
    
        public virtual ObjectResult<GetTest_Result> GetTest(Nullable<int> testID)
        {
            var testIDParameter = testID.HasValue ?
                new ObjectParameter("TestID", testID) :
                new ObjectParameter("TestID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTest_Result>("GetTest", testIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetTestID(Nullable<int> id_Conv, Nullable<int> tipo)
        {
            var id_ConvParameter = id_Conv.HasValue ?
                new ObjectParameter("id_Conv", id_Conv) :
                new ObjectParameter("id_Conv", typeof(int));
    
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetTestID", id_ConvParameter, tipoParameter);
        }
    
        public virtual int GuardarRespuestaPregunta(Nullable<int> pruebaID, Nullable<int> preguntaID, Nullable<int> opcion)
        {
            var pruebaIDParameter = pruebaID.HasValue ?
                new ObjectParameter("PruebaID", pruebaID) :
                new ObjectParameter("PruebaID", typeof(int));
    
            var preguntaIDParameter = preguntaID.HasValue ?
                new ObjectParameter("PreguntaID", preguntaID) :
                new ObjectParameter("PreguntaID", typeof(int));
    
            var opcionParameter = opcion.HasValue ?
                new ObjectParameter("opcion", opcion) :
                new ObjectParameter("opcion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GuardarRespuestaPregunta", pruebaIDParameter, preguntaIDParameter, opcionParameter);
        }
    
        public virtual ObjectResult<ModulosParaPreRequisitos_Result> ModulosParaPreRequisitos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ModulosParaPreRequisitos_Result>("ModulosParaPreRequisitos");
        }
    
        public virtual ObjectResult<GetEstudianteFromMatricula_Result> GetEstudianteFromMatricula(string matri)
        {
            var matriParameter = matri != null ?
                new ObjectParameter("matri", matri) :
                new ObjectParameter("matri", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEstudianteFromMatricula_Result>("GetEstudianteFromMatricula", matriParameter);
        }
    
        public virtual int AgregarModulosADocente(Nullable<int> idModulo, Nullable<int> idDocente)
        {
            var idModuloParameter = idModulo.HasValue ?
                new ObjectParameter("idModulo", idModulo) :
                new ObjectParameter("idModulo", typeof(int));
    
            var idDocenteParameter = idDocente.HasValue ?
                new ObjectParameter("idDocente", idDocente) :
                new ObjectParameter("idDocente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarModulosADocente", idModuloParameter, idDocenteParameter);
        }
    
        public virtual int CambiarDocenteCoordinador(Nullable<int> idDocente)
        {
            var idDocenteParameter = idDocente.HasValue ?
                new ObjectParameter("IdDocente", idDocente) :
                new ObjectParameter("IdDocente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CambiarDocenteCoordinador", idDocenteParameter);
        }
    
        public virtual int AgregarDocente(string nombres, string apellidos, string usuario, string password, string genero, string area, string carrera)
        {
            var nombresParameter = nombres != null ?
                new ObjectParameter("nombres", nombres) :
                new ObjectParameter("nombres", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("apellidos", apellidos) :
                new ObjectParameter("apellidos", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(string));
    
            var areaParameter = area != null ?
                new ObjectParameter("area", area) :
                new ObjectParameter("area", typeof(string));
    
            var carreraParameter = carrera != null ?
                new ObjectParameter("carrera", carrera) :
                new ObjectParameter("carrera", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarDocente", nombresParameter, apellidosParameter, usuarioParameter, passwordParameter, generoParameter, areaParameter, carreraParameter);
        }
    }
}
