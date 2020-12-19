using SistemasDistribuidos.HelpDesk.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemasDistribuidos.HelpDesk.DAO
{
    public interface InterfaceIncidenteRepository
    {
        Response<int> Registrar(Incidencia incidencia);
    }
}
