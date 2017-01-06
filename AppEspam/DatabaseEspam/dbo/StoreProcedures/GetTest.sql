CREATE PROCEDURE [dbo].[GetTest]
	@TestID int
AS
	SELECT pregunta, opcion1, opcion2, opcion3, opcion4, opcion_correcta 
	from Preguntas inner join Test_Pregunta on Test_Pregunta.Id_pregunta = Preguntas.id
	where @TestID = Test_Pregunta.id_test
RETURN 0