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
                cfg.CreateMap<Incidencia, IncidenciaRequest>();
                cfg.CreateMap<Incidencia, IncidenciaResponse>();
                cfg.CreateMap<IncidenciaRequest, Incidencia>();
                cfg.CreateMap<IncidenciaResponse, Incidencia>();
            });

            return config.CreateMapper();
        }
    }

}
