CREATE PROCEDURE [dbo].[CambiarDocenteCoordinador]
	@IdDocente int 
AS
	truncate table Coordinadores;
	insert into Coordinadores (Id_Docente) values (@IdDocente);

RETURN 0
