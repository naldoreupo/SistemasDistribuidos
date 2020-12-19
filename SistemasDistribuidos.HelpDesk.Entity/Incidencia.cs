using System;
using System.Collections.Generic;

#nullable disable

namespace SistemasDistribuidos.HelpDesk.DAO
{
    public partial class Incidencia
    {
        public int IdIncidencia { get; set; }
        public int? IdEstado { get; set; }
        public int? IdPrioridad { get; set; }
        public int? IdUsuarioSolicitante { get; set; }
        public int? IdProducto { get; set; }
        public string NivelMovimiento { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaAtencion { get; set; }
        public bool? CheckAtencion { get; set; }
        public DateTime? FechaPendiente { get; set; }
        public bool? CheckPendiente { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public bool? CheckAnulacion { get; set; }
        public bool FechaTermino { get; set; }
        public string CheckTermino { get; set; }
        public bool? EstaActivo { get; set; }
    }
}
