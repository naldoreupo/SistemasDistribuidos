using AutoMapper;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.DTO;
using System;

namespace SistemasDistribuidos.HelpDesk.Config
{

    public static class Maps
    {
        public static IMapper InitMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Incidencia, IncidenteRequest>();
                cfg.CreateMap<Incidencia, IncidenteResponse>();
                cfg.CreateMap<IncidenteRequest, Incidencia>();
                cfg.CreateMap<IncidenteResponse, Incidencia>();
            });

            return config.CreateMapper();
        }
    }

}
