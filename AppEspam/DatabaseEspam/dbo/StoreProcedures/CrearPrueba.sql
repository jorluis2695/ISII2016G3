CREATE PROCEDURE [dbo].[CrearPrueba]
	@EstudianteID int,
	@ConvocatoriaTestID int,
	@fecha date,
	@calif float
AS
	INSERT INTO Prueba (ConvocatoriaTestID, Id_estudiante, Fecha, Calificacion)
	VALUES (@ConvocatoriaTestID, @EstudianteID, @fecha, @calif)
RETURN 0
