CREATE TABLE [dbo].[ModulosPrerequisitos]
(
    [IdMod1] INT NULL, 
    [IdMod2] INT NULL, 
    CONSTRAINT [FK_ModulosPrerequisitos_ToTable] FOREIGN KEY ([IdMod1]) REFERENCES [Modulos]([Id]), 
    CONSTRAINT [FK_ModulosPrerequisitos_ToTable_1] FOREIGN KEY ([IdMod2]) REFERENCES [Modulos]([Id])
)
