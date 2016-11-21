CREATE TABLE [dbo].[Test_estudiante]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Id_test] INT NULL, 
    [Id_estudiante] INT NULL, 
    [Fecha] DATE NULL, 
    [Calificacion] FLOAT NULL, 
    CONSTRAINT [FK_Test_estudiante_ToTable] FOREIGN KEY ([Id_test]) REFERENCES [Test]([Id]), 
    CONSTRAINT [FK_Test_estudiante_ToTable_1] FOREIGN KEY ([Id_estudiante]) REFERENCES [Estudiantes]([Id])
)
