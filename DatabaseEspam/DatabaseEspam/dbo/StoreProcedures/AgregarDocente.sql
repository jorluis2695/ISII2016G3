CREATE PROCEDURE [dbo].[AgregarDocente]
	@nombres nvarchar(30),
	@apellidos nvarchar(30),
	@usuario nvarchar(15),
	@password nvarchar(15),
	@genero nvarchar(10),
	@area nvarchar(10),
	@carrera nvarchar(10)
AS
	insert into Docentes (Nombres, Apellidos, Usuario, Password, Genero, Area, Carrera) values (@nombres, @apellidos, @usuario, @password, @genero, @area, @carrera)
RETURN 0
