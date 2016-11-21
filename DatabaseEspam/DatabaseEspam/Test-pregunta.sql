CREATE TABLE [dbo].[Table1]
(
	[Id_test] INT NOT NULL, 
    [Id_pregunta] INT NOT NULL, 
    [opcion_correcta] INT NULL, 
    CONSTRAINT [fk_test] FOREIGN KEY (Id_test) REFERENCES [Test]([Id]), 
    CONSTRAINT [fk_pregunta] FOREIGN KEY (Id_pregunta) REFERENCES [Preguntas]([Id]) 
)
