use HelpDeskDB
go

create table MovimientoUsuario
(
	IdMovimientoUsuario int primary key identity(1,1),
	IdIncidencia int null,
	IdUsuario int null,
	IdPrioridad int null,
	IdEstado int null,
	Descripcion varchar(128),
	FechaRegistro Datetime null,
	Correlativo int null,
	EstaActivo bit null
)
go


create table SolicitudSupervisor
(
	idSolicitud int primary key identity(1,1),
	IdSupervisor int null,
	IdUsuario int null,
	IdEstado int null,
	Descripcion varchar(128),
	FechaRegistro Datetime null,
	FechaAprobacion Datetime null,
	FechaRechazo Datetime null,
	EstaActivo bit null
)
go

