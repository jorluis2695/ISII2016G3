USE [master]
GO
/****** Object:  Database [Semillero]    Script Date: 27/11/2016 21:41:01 ******/
CREATE DATABASE [Semillero]

USE [Semillero]
GO
/****** Object:  Table [dbo].[Convocatoria]    Script Date: 27/11/2016 21:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
/****** Object:  Table [dbo].[ConvocatoriaTest]    Script Date: 27/11/2016 21:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConvocatoriaTest](
	[ConvocatoriaTestID] [int] NOT NULL,
	[Descripcion] [nchar](10) NULL,
	[TestID] [int] NULL,
	[ConvocatoriaID] [int] NULL,
 CONSTRAINT [PK_ConvocatoriaTest] PRIMARY KEY CLUSTERED 
(
	[ConvocatoriaTestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 27/11/2016 21:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
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

GO
/****** Object:  Table [dbo].[Pregunta_estudiante]    Script Date: 27/11/2016 21:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pregunta_estudiante](
	[Id] [int] NOT NULL,
	[Id_pregunta] [int] NOT NULL,
	[PruebaID] [int] NOT NULL,
	[opcion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Preguntas]    Script Date: 27/11/2016 21:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
/****** Object:  Table [dbo].[Prueba]    Script Date: 27/11/2016 21:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
/****** Object:  Table [dbo].[Test]    Script Date: 27/11/2016 21:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[TestID] [int] NOT NULL,
	[TipoTestID] [int] NULL,
	[fecha_creacion] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[TestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Test-Pregunta]    Script Date: 27/11/2016 21:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test-Pregunta](
	[Id_test] [int] NOT NULL,
	[Id_pregunta] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoTest]    Script Date: 27/11/2016 21:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTest](
	[TipoTestId] [int] NOT NULL,
	[Descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_TipoTest] PRIMARY KEY CLUSTERED 
(
	[TipoTestId] ASC
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
GO
ALTER TABLE [dbo].[Pregunta_estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_estudiante_Prueba] FOREIGN KEY([PruebaID])
REFERENCES [dbo].[Prueba] ([PruebaID])
GO
ALTER TABLE [dbo].[Pregunta_estudiante] CHECK CONSTRAINT [FK_Pregunta_estudiante_Prueba]
GO
ALTER TABLE [dbo].[Pregunta_estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_estudiante_ToTable_1] FOREIGN KEY([Id_pregunta])
REFERENCES [dbo].[Preguntas] ([Id])
GO
ALTER TABLE [dbo].[Pregunta_estudiante] CHECK CONSTRAINT [FK_Pregunta_estudiante_ToTable_1]
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
GO
ALTER TABLE [dbo].[Test]  WITH CHECK ADD  CONSTRAINT [FK_Test_TipoTest] FOREIGN KEY([TipoTestID])
REFERENCES [dbo].[TipoTest] ([TipoTestId])
GO
ALTER TABLE [dbo].[Test] CHECK CONSTRAINT [FK_Test_TipoTest]
GO
ALTER TABLE [dbo].[Test-Pregunta]  WITH CHECK ADD  CONSTRAINT [fk_pregunta] FOREIGN KEY([Id_pregunta])
REFERENCES [dbo].[Preguntas] ([Id])
GO
ALTER TABLE [dbo].[Test-Pregunta] CHECK CONSTRAINT [fk_pregunta]
GO
ALTER TABLE [dbo].[Test-Pregunta]  WITH CHECK ADD  CONSTRAINT [fk_test] FOREIGN KEY([Id_test])
REFERENCES [dbo].[Test] ([TestID])
GO
ALTER TABLE [dbo].[Test-Pregunta] CHECK CONSTRAINT [fk_test]
GO
USE [master]
GO
ALTER DATABASE [Semillero] SET  READ_WRITE 
GO
