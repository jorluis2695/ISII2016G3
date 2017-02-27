CREATE TABLE [dbo].[Test_Pregunta](
	[Id_test] [int] NOT NULL IDENTITY,
	[Id_pregunta] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Test_Pregunta]  WITH CHECK ADD  CONSTRAINT [fk_pregunta] FOREIGN KEY([Id_pregunta])
REFERENCES [dbo].[Preguntas] ([Id])
GO

ALTER TABLE [dbo].[Test_Pregunta] CHECK CONSTRAINT [fk_pregunta]
GO
ALTER TABLE [dbo].[Test_Pregunta]  WITH CHECK ADD  CONSTRAINT [fk_test] FOREIGN KEY([Id_test])
REFERENCES [dbo].[Test] ([TestID])
GO

ALTER TABLE [dbo].[Test_Pregunta] CHECK CONSTRAINT [fk_test]