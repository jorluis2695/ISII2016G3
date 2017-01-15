CREATE TABLE [dbo].[Pregunta_estudiante](
	[Id] [int] NOT NULL IDENTITY,
	[Id_pregunta] [int] NOT NULL,
	[PruebaID] [int] NOT NULL,
	[opcion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pregunta_estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_estudiante_Prueba] FOREIGN KEY([PruebaID])
REFERENCES [dbo].[Prueba] ([PruebaID])
GO

ALTER TABLE [dbo].[Pregunta_estudiante] CHECK CONSTRAINT [FK_Pregunta_estudiante_Prueba]
GO
ALTER TABLE [dbo].[Pregunta_estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_estudiante_ToTable_1] FOREIGN KEY([Id_pregunta])
REFERENCES [dbo].[Preguntas] ([Id])
GO

ALTER TABLE [dbo].[Pregunta_estudiante] CHECK CONSTRAINT [FK_Pregunta_estudiante_ToTable_1]