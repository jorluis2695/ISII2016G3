CREATE TABLE [dbo].[Convocatoria](
	[Id] [int] NOT NULL,
	[fecha_inicio] [date] NULL,
	[fecha_fin] [date] NULL,
	[descrpcion] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]