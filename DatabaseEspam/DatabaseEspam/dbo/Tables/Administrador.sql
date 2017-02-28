CREATE TABLE [dbo].[Administrador]
(
	[AdminID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombres] NVARCHAR(50) NULL, 
    [Apellidos] NVARCHAR(50) NULL, 
    [Cedula] NVARCHAR(50) NULL
)
