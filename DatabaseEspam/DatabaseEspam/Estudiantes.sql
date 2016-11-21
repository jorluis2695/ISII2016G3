CREATE TABLE [dbo].[Estudiantes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nombres] NVARCHAR(50) NULL, 
    [Apellidos] NVARCHAR(50) NULL, 
    [Carrera] NVARCHAR(50) NULL, 
    [Cedula] NCHAR(15) NULL, 
    [Matricula] NCHAR(15) NULL, 
    [Genero] NCHAR(15) NULL 
)
