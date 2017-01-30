CREATE PROCEDURE [dbo].[CrearConvocatoria]
	@fecha_ini date,
	@fecha_fin date,
	@descripcion text
AS
	INSERT INTO Convocatoria (fecha_inicio, fecha_fin, descripcion)
	values(@fecha_ini, @fecha_fin, @descripcion)
RETURN 0
