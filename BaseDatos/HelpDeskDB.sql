CREATE DATABASE [HelpDeskDB];
GO
USE [HelpDeskDB]
GO
CREATE TABLE [dbo].[Incidencias](
	[IdIncidencia] [int] IDENTITY(1,1) NOT NULL,
	[IdEstado] [int] NULL,
	[IdPrioridad] [int] NULL,
	[IdUsuarioSolicitante] [int] NULL,
	[IdProducto] [int] NULL,
	[NivelMovimiento] [varchar](30) NULL,
	[Titulo] [varchar](50) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[FechaRegistro] [date] NULL,
	[FechaAtencion] [date] NULL,
	[CheckAtencion] [bit] NULL,
	[FechaPendiente] [date] NULL,
	[CheckPendiente] [bit] NULL,
	[FechaAnulacion] [date] NULL,
	[CheckAnulacion] [bit] NULL,
	[FechaTermino] [date] NULL,
	[CheckTermino] [nchar](10) NULL,
	[EstaActivo] [bit] NULL,
 CONSTRAINT [PK_Incidencia] PRIMARY KEY CLUSTERED 
(
	[IdIncidencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Incidencias] ADD  CONSTRAINT [DF_Incidencia_EstaActivo]  DEFAULT ((1)) FOR [EstaActivo]
GO
