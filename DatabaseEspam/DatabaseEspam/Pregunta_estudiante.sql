CREATE TABLE [dbo].[Pregunta_estudiante]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Id_pregunta] INT NOT NULL, 
    [Id_estudiante] INT NOT NULL, 
    [opcion] INT NOT NULL, 
    CONSTRAINT [FK_Pregunta_estudiante_ToTable] FOREIGN KEY ([Id_estudiante]) REFERENCES [Estudiantes]([Id]), 
    CONSTRAINT [FK_Pregunta_estudiante_ToTable_1] FOREIGN KEY ([Id_pregunta]) REFERENCES [Preguntas]([Id]) 
)
