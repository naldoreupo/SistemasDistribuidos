using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.Entity;

namespace SistemasDistribuidos.HelpDesk.DAO
{
    public interface InterfaceIncidenteRepository
    {
        Response<int> Registrar(Incidencia incidencia);
        Response<int> Anular(Incidencia incidencia);
        Response<Incidencia> Obtener(int idIncidencia);
        
        Response<int> EscalarProvExt(MovimientoProveedor movimiento);

       
        Response<int> EscalarInt(MovimientoUsuario movimiento);
        Response<int> Derivar(MovimientoUsuario movimiento);
	}
}
