CREATE TABLE [dbo].[Prueba](
	[PruebaID] [int] NOT NULL,
	[ConvocatoriaTestID] [int] NULL,
	[Id_estudiante] [int] NULL,
	[Fecha] [date] NULL,
	[Calificacion] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[PruebaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Prueba]  WITH CHECK ADD  CONSTRAINT [FK_Prueba_ConvocatoriaTest] FOREIGN KEY([ConvocatoriaTestID])
REFERENCES [dbo].[ConvocatoriaTest] ([ConvocatoriaTestID])
GO

ALTER TABLE [dbo].[Prueba] CHECK CONSTRAINT [FK_Prueba_ConvocatoriaTest]
GO
ALTER TABLE [dbo].[Prueba]  WITH CHECK ADD  CONSTRAINT [FK_Test_estudiante_ToTable_1] FOREIGN KEY([Id_estudiante])
REFERENCES [dbo].[Estudiantes] ([Id])
GO

ALTER TABLE [dbo].[Prueba] CHECK CONSTRAINT [FK_Test_estudiante_ToTable_1]