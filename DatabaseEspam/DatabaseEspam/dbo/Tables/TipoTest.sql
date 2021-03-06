﻿CREATE TABLE [dbo].[TipoTest](
	[TipoTestId] [int] NOT NULL IDENTITY,
	[Descripcion] TEXT NULL,
 CONSTRAINT [PK_TipoTest] PRIMARY KEY CLUSTERED 
(
	[TipoTestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]