CREATE TABLE [dbo].[Estudiantes](
	[Id] [int] NOT NULL IDENTITY,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Carrera] [nvarchar](50) NULL,
	[Cedula] [nchar](10) NULL,
	[Matricula] [nchar](15) NULL,
	[Genero] [nchar](15) NULL,
[Password] NCHAR(16) NULL, 
    PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]