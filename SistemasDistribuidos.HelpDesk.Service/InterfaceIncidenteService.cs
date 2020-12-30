using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.Entity;
using System.Collections.Generic;

namespace SistemasDistribuidos.HelpDesk.Service
{
    public interface InterfaceIncidenteService
    {
        Response<int> Registrar(Incidencia incidencia);

        Response<int> Anular(int idIncidencia);

        Response<int> EscalarProvExt(MovimientoProveedor movimiento);
        Response<int> ObtenerEstado(int idIncidencia);
		Response<int> EscalarInt(MovimientoUsuario movimiento);
        Response<int> Derivar(MovimientoUsuario movimiento);
        Response<Incidencia> ObtenerIncidencia(int idIncidencia);
        Response<int> Reabrir(int idIncidencia);
        Response<int> SolicitarEscalamiento(int idIncidencia);
        Response<int> Autorizar(int idIncidencia);
        Response<Incidencia> Listar();
    }
}
