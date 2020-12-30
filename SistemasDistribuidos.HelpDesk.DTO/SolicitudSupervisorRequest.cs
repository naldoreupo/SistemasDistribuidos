using System;

namespace SistemasDistribuidos.HelpDesk.DTO
{
    public class SolicitudSupervisorRequest
    {
        public int IdSolicitud { get; set; }
        public int? IdSupervisor { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEstado { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public bool? EstaActivo { get; set; }
    }
}
