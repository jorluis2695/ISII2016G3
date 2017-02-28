CREATE PROCEDURE [dbo].[AgregarPreguntaATest]
	@idTest int,
	@pregunta ntext,
	@op1 ntext,
	@op2 ntext,
	@op3 ntext,
	@op4 ntext,
	@opC int
AS
	Declare @idPregunta int
	INSERT INTO Preguntas (pregunta, opcion1, opcion2, opcion3, opcion4, opcion_correcta)
	values(@pregunta, @op1, @op2, @op3, @op4, @opC)
	Select @idPregunta = SCOPE_IDENTITY();
	Insert into Test_Pregunta values(@idTest, @idPregunta)


RETURN 0