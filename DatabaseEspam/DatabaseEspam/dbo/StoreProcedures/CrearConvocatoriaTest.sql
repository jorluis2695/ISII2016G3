CREATE PROCEDURE [dbo].[CrearConvocatoriaTest]
	@idConvocatoria int,
	@tipo int,
	@fecha date,
	@tiempo int
AS
	DECLARE @TestID int
	insert into Test (TipoTestID, fecha_creacion, tiempo)
	values(@tipo, @fecha, @tiempo)
	Select @TestID = SCOPE_IDENTITY();
	insert into ConvocatoriaTest (ConvocatoriaID, TestID)
	values (@idConvocatoria, @TestID)
	

RETURN 0
