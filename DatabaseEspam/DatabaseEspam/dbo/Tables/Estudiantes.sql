CREATE TABLE [dbo].[Estudiantes](
	[Id] [int] NOT NULL IDENTITY,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Carrera] [nvarchar](50) NULL,
	[Cedula] NVARCHAR(10) NULL,
	[Matricula] NVARCHAR(15) NULL,
	[Genero] NVARCHAR(15) NULL,
[Password] NVARCHAR(16) NULL, 
    PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
) ON [PRIMARY]