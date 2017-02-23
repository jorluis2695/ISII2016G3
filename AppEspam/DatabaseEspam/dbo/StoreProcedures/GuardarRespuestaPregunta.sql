CREATE PROCEDURE [dbo].[GuardarRespuestaPregunta]
	@PruebaID int,
	@PreguntaID int,
	@opcion int
AS
	INSERT INTO Pregunta_estudiante
	VALUES (@PruebaID, @PreguntaID, @opcion)
RETURN 0
