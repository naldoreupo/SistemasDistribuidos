using System;

namespace SistemasDistribuidos.HelpDesk.DAO
{
    public class IncidenteRepository : InterfaceIncidenteRepository
    {
        private readonly HelpDeskDBContext _incidenteContext;

        public IncidenteRepository(HelpDeskDBContext incidenteContext)
        {
            _incidenteContext = incidenteContext;
        }

        public bool Registrar(Incidencia incidente)
        {
            _incidenteContext.Incidencia.Add(incidente);
            _incidenteContext.SaveChanges();
            return true;
        }

    }
}
