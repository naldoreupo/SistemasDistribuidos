using System;

namespace SistemasDistribuidos.HelpDesk.DTO
{
    public class IncidenciaRequest
    {
        public int? IdEstado { get; set; }
        public int? IdPrioridad { get; set; }
        public int? IdUsuarioSolicitante { get; set; }
        public int? IdProducto { get; set; }
        public string NivelMovimiento { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
