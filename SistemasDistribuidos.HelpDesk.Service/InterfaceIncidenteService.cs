using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemasDistribuidos.HelpDesk.Service
{
    public interface InterfaceIncidenteService
    {
        Response<int> Registrar(Incidencia incidencia);
    }
}
