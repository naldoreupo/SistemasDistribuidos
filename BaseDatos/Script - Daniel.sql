use HelpDeskDB
go

create table MovimientosDeProveedor
(
	IdMovimientoProveedor int primary key identity(1,1),
	IdIncidencia int null,
	IdEstado int null,
	Descripcion varchar(128),
	FechaRegistro Datetime null,
	FechaAprobacion Datetime null,
	Correlativo int null,
	EstaActivo bit null
)
go

update Incidencias set IdEstado = 1 where IdIncidencia = 1