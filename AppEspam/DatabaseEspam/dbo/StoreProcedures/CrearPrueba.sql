CREATE PROCEDURE [dbo].[CrearPrueba]
	@EstudianteID int,
	@ConvocatoriaTestID int,
	@fecha date
AS
	INSERT INTO Prueba (ConvocatoriaTestID, Id_estudiante, Fecha)
	VALUES (@ConvocatoriaTestID, @EstudianteID, @fecha)
RETURN 0
