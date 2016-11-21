CREATE TABLE [dbo].[Convocatoria]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [fecha_inicio] DATE NULL, 
    [fecha_fin] DATE NULL, 
    [descrpcion] NVARCHAR(50) NULL
)
