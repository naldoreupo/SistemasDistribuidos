using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;

namespace SistemasDistribuidos.HelpDesk.Service
{
    public interface InterfaceIncidenteService
    {
        Response<int> Registrar(Incidencia incidencia);

        Response<int> Anular(int idIncidencia);
    }
}
