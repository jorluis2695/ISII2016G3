﻿CREATE TABLE [dbo].[Estudiantes](
	[Id] [int] NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Carrera] [nvarchar](50) NULL,
	[Cedula] [nchar](15) NULL,
	[Matricula] [nchar](15) NULL,
	[Genero] [nchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]