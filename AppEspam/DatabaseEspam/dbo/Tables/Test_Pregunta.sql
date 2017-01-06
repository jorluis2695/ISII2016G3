	[Id_test] [int] NOT NULL,
	[Id_pregunta] [int] NOT NULL
) ON [PRIMARY]
GO
REFERENCES [dbo].[Preguntas] ([Id])
GO

GO
REFERENCES [dbo].[Test] ([TestID])
GO

