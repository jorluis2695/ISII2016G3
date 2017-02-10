CREATE TABLE [dbo].[ConvocatoriaTest](
	[ConvocatoriaTestID] [int] NOT NULL IDENTITY,
	[TestID] [int] NULL,
	[ConvocatoriaID] [int] NULL,
 CONSTRAINT [PK_ConvocatoriaTest] PRIMARY KEY CLUSTERED 
(
	[ConvocatoriaTestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ConvocatoriaTest]  WITH CHECK ADD  CONSTRAINT [FK_ConvocatoriaTest_Convocatoria] FOREIGN KEY([ConvocatoriaID])
REFERENCES [dbo].[Convocatoria] ([Id])
GO

ALTER TABLE [dbo].[ConvocatoriaTest] CHECK CONSTRAINT [FK_ConvocatoriaTest_Convocatoria]
GO
ALTER TABLE [dbo].[ConvocatoriaTest]  WITH CHECK ADD  CONSTRAINT [FK_ConvocatoriaTest_Test] FOREIGN KEY([TestID])
REFERENCES [dbo].[Test] ([TestID])
GO

ALTER TABLE [dbo].[ConvocatoriaTest] CHECK CONSTRAINT [FK_ConvocatoriaTest_Test]