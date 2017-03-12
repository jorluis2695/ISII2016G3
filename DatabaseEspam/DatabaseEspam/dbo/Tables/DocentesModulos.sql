CREATE TABLE [dbo].[DocentesModulos]
(
	[Id] INT NOT NULL IDENTITY, 
    [Id_Modulo] INT NULL, 
    [Id_Docente] INT NULL, 
    PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[DocentesModulos]  WITH CHECK ADD  CONSTRAINT [fk_modulo] FOREIGN KEY([Id_Modulo])
REFERENCES [dbo].[Modulos] ([Id])
GO

ALTER TABLE [dbo].[DocentesModulos] CHECK CONSTRAINT [fk_modulo]
GO
ALTER TABLE [dbo].[DocentesModulos]  WITH CHECK ADD  CONSTRAINT [fk_docente] FOREIGN KEY([Id_Docente])
REFERENCES [dbo].[Modulos] ([ID])
GO

ALTER TABLE [dbo].[DocentesModulos] CHECK CONSTRAINT [fk_docente]