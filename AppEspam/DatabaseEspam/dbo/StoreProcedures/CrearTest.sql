CREATE PROCEDURE [dbo].[CrearTest]
	@tipo int,
	@fecha date = datetime,
	@tiempo int
AS
	insert into Test (TipoTestID, fecha_creacion, tiempo)
	values(@tipo, @fecha, @tiempo)
RETURN 0