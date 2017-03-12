CREATE PROCEDURE [dbo].[GetEstudianteFromMatricula]
	@matri nchar(15)
AS
	SELECT Nombres, Apellidos, Carrera, Cedula, Matricula, Genero, Password  from Estudiantes
	where @matri = Estudiantes.Matricula
RETURN 0
