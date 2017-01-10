CREATE TABLE [dbo].[Preguntas](
	[Id] [int] NOT NULL,
	[pregunta] [ntext] NULL,
	[opcion1] [ntext] NULL,
	[opcion2] [ntext] NULL,
	[opcion3] [ntext] NULL,
	[opcion4] [ntext] NULL,
	[opcion_correcta] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]