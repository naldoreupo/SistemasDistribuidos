using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.Entity;

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
		Incidencia ObtenerIncidencia(int idIncidencia);
	}
}
