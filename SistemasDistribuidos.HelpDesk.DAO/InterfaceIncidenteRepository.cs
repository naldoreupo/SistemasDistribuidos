using System;
using System.Collections.Generic;
using System.Text;

namespace SistemasDistribuidos.HelpDesk.DAO
{
    public interface InterfaceIncidenteRepository
    {
        bool Registrar(Incidencia incidente);
    }
}
