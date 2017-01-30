Tablas:
- Convocatoria:		Registra la Convocatorias, es decir fechas inicio y fin y una descripcion
- Test: 		Registra los Test, es decir el tipo del test, la fecha de creacion, y el tiempo para tomarlo.
- ConvocatoriaTest:	Esta tabla relaciona las convocatorias con los Test, ya que en cada convocatoria hay dos tipos
			de Tests, solo registra el id de la convocatoria y el id del test.
- TipoTest:		Esta tabla es para  registrar los tipos de los test, en este caso solo tenemos 2.
- Preguntas: 		Esta tabla registra las preguntas, en las cuales se guarda el enunciado, las 4 opciones, y 
			la opcion correcta.
- Test_Pregunta:	En esta tabla sirve para agregar relacionar las preguntas con los Test a los que pertenece
			Tiene el id del test y el id de la pregunta.
- Estudiante: 		Esta Registra los datos de los estudiantes.
- Prueba: 		Esta instancia se crea por cada Test que tome un estudiante, tiene como columnas. 
			El id de la ConvocatoriaTest (que se explica que es arriba), Id del estudiante, fecha,
			y la calificacion.
- PreguntaEstudiante: 	esta tabla relaciona la Prueba (que se explica anteriormente), el id de una pregunta, y 
			que opcion marco el estudiante, esto sirve para saber que opcion tomo el estudiante en cada
			pregunta, (el id del estudiante se encuentra dentro de prueba, por eso solo se guarda el 
			id de la prueba


Stored Procedures.
Los que dicen crear + un nombre de una tabla es para registrar datos en esa tabla.

- GetTest:		Este procedimiento, me devuelve todas las preguntas (enunciado y opciones) de un test
			necesito pasar el id del test.
- GetTestID:		Este procedimiento me devuelve el ID de un test, pasando como datos el id de una convocatoria
			y el id de un test.
- AgregarPreguntaATest: Este procedure ingresa una fila en la tabla Test_Ptegunta
- GuardarRespuestaAPregunta:	Este procedure crea una fila en PreguntaEstudiante.