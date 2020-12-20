using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;
using System;

namespace SistemasDistribuidos.HelpDesk.Service
{
    public class IncidenteService : InterfaceIncidenteService
    {
        private readonly InterfaceIncidenteRepository _interfaceIncidenteRepository;

        public IncidenteService(InterfaceIncidenteRepository interfaceIncidenteRepository)
        {
            _interfaceIncidenteRepository = interfaceIncidenteRepository;
        }

        public Response<int> Anular(int idIncidencia)
        {
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);

            if (incidencia.Status)
            {
                incidencia.Data.FechaAnulacion = DateTime.Now;
                incidencia.Data.CheckAnulacion = true;

                return _interfaceIncidenteRepository.Anular(incidencia.Data);
            }

            return new Response<int>
            {
                Status = false,
                Message = "El IdIncidencia no se encuentra en la base de datos"
            };
        }

        public Response<int> Registrar(Incidencia incidencia)
        {
            return _interfaceIncidenteRepository.Registrar(incidencia);
        }
    }
}
