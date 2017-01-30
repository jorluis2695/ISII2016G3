CREATE PROCEDURE [dbo].[CrearConvocatoriaTest]
	@idConvocatoria int,
	@idTest int
AS
	Insert into ConvocatoriaTest values(@idTest, @idConvocatoria)
RETURN 0
