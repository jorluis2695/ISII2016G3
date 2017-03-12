CREATE PROCEDURE [dbo].[AgregarModulosADocente]
	@idModulo int,
	@idDocente int
AS
	insert into DocentesModulos (Id_Modulo,Id_Docente) values (@idModulo, @idDocente)
RETURN 0

