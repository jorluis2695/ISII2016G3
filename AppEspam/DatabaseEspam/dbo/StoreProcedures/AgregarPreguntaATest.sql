CREATE PROCEDURE [dbo].[AgregarPreguntaATest]
	@idPregunta int,
	@idTest int
AS
	Insert into Test_Pregunta values(@idTest, @idPregunta)
RETURN 0