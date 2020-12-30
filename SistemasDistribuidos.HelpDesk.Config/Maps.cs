using AutoMapper;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.DTO;
using SistemasDistribuidos.HelpDesk.Entity;
using System;

namespace SistemasDistribuidos.HelpDesk.Config
{

    public static class Maps
    {
        public static IMapper InitMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {    
                cfg.CreateMap<Incidencia, IncidenciaRequest>();
                cfg.CreateMap<Incidencia, IncidenciaResponse>();
                cfg.CreateMap<IncidenciaRequest, Incidencia>();
                cfg.CreateMap<IncidenciaResponse, Incidencia>();

                cfg.CreateMap<MovimientoProveedor, MovimientoProveedorRequest>();
                cfg.CreateMap<MovimientoProveedor, MovimientoProveedorResponse>();
                cfg.CreateMap<MovimientoProveedorRequest, MovimientoProveedor>();
                cfg.CreateMap<MovimientoProveedorResponse, MovimientoProveedor>();

                cfg.CreateMap<MovimientoUsuario, MovimientoUsuarioRequest>();
                cfg.CreateMap<MovimientoUsuarioRequest, MovimientoUsuario>();

                cfg.CreateMap<SolicitudSupervisor, SolicitudSupervisorRequest>();
                cfg.CreateMap<SolicitudSupervisorRequest, SolicitudSupervisor>();
            });

            return config.CreateMapper();
        }
    }

}
