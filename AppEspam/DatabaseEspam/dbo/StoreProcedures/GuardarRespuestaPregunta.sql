CREATE PROCEDURE [dbo].[GuardarRespuestaPregunta]
	@PruebaID int,
	@PreguntaID int,
	@opcion int
AS
	INSERT INTO PregPregunta_estudiante
	VALUES (@PruebaID, @PreguntaID, @opcion)
RETURN 0
