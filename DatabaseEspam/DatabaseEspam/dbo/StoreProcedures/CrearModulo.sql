CREATE PROCEDURE [dbo].[CrearModulo]
	@nombre text,
	@desc text
AS
	declare @r int
	Insert into Modulos (Nombre, Syllabus)
	values (@nombre, @desc)
	select @r = SCOPE_IDENTITY()
	Select @r
RETURN 0
