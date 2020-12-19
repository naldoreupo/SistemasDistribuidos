using SistemasDistribuidos.HelpDesk.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemasDistribuidos.HelpDesk.Service
{
    public interface InterfaceIncidenteService
    {
        bool Registrar(Incidencia incidente);
    }
}
