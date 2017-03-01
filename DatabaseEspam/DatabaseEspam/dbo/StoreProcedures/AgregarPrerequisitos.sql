CREATE PROCEDURE [dbo].[AgregarPrerequisitos]
	@idModulo int,
	@idPrerequisito int
AS
	insert into ModulosPrerequisitos values (@idModulo, @idPrerequisito)
RETURN 0
