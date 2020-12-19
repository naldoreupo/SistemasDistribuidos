using SistemasDistribuidos.HelpDesk.Config;
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

        public Response<int> Registrar(Incidencia incidencia)
        {
            try
            {
                _incidenteContext.Incidencias.Add(incidencia);
                _incidenteContext.SaveChanges();

                return new Response<int>()
                {
                    Status = true,
                    Message = "Incidencia agregada correctamente",
                    Data = incidencia.IdIncidencia
                };
            }
            catch(Exception ex)
            {
                return new Response<int>()
                {
                    Status = false,
                    Message = "Error al intentar agregar incidencia",
                    Data = 0
                };
            }
        }
    }
}
