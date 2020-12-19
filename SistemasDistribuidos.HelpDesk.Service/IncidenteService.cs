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
        public Response<int> Registrar(Incidencia incidencia)
        {
            return _interfaceIncidenteRepository.Registrar(incidencia);
        }
    }
}
