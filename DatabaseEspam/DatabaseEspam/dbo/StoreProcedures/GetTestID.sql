CREATE PROCEDURE [dbo].[GetTestID]
	@id_Conv int,
	@Tipo int
AS
	SELECT Test.TestID 
	from ConvocatoriaTest inner join Test on ConvocatoriaTest.TestID = Test.TestID 
	where @id_Conv = ConvocatoriaTest.ConvocatoriaID and @Tipo = Test.TipoTestID
RETURN 0
