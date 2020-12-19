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
        public bool Registrar(Incidencia incidente)
        {
            return _interfaceIncidenteRepository.Registrar(incidente);
        }
    }
}
