
CrearConvocatoria '10-02-2017', '20-03-2017', 'Primera Convocatoria'

insert into TipoTest values('Test de Aptitudes')
insert into TipoTest values('Test de Postulacion')

--esta linea crea el test, y lo relaciona con una convocatoria

Select SCOPE_IDENTITY()

CrearConvocatoria '12-01-2017', '12-04-2017', 'Primera Convocatoria'

CrearConvocatoriaTest '3', '1', '12-01-2017', '120'
CrearConvocatoriaTest '3', '2', '12-01-2017', '120'

AgregarPreguntaATest '1', 'pregunta  2345', 'op15', 'op25', 'op35', 'op45', '2'
AgregarPreguntaATest '1', 'pregunta ', 'op1', 'op2', 'op3', 'op4', '5'
Delete from Modulos

Delete from Convocatoria

select * from Modulos

select * from Convocatoria
select * from Preguntas
select * from TipoTest
select * from Test
select * from ConvocatoriaTest
select * from Preguntas
select * from Test_Pregunta

set dateformat YMD

insert into TipoTest (Descripcion)  values ('Test Postulacion')