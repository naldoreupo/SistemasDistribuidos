using System;

namespace SistemasDistribuidos.HelpDesk.DTO
{
    public class MovimientoUsuarioRequest
    {
        public int IdMovimientoUsuario { get; set; }
        public int? IdIncidencia { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdPrioridad { get; set; }
        public int? IdEstado { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? Correlativo { get; set; }
        public bool? EstaActivo { get; set; }
    }
}
