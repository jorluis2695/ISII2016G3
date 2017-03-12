﻿CREATE TABLE [dbo].[Coordinadores]
(
	[Id] INT NOT NULL IDENTITY, 
    [Id_Docente] INT NULL
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Coordinadores]  WITH CHECK ADD  CONSTRAINT [fk_docenteCoordinador] FOREIGN KEY([Id_Docente])
REFERENCES [dbo].[Docentes] ([Id])
GO

ALTER TABLE [dbo].[Coordinadores] CHECK CONSTRAINT [fk_docenteCoordinador]
GO