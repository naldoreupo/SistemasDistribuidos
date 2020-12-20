using System;
using System.ComponentModel.DataAnnotations;

namespace SistemasDistribuidos.HelpDesk.Entity
{
    public class MovimientoProveedor
    {
        [Key]
        public int IdMovimientoProveedor { get; set; }
        public int? IdIncidencia { get; set; }
        public int? IdEstado { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public int? Correlativo { get; set; }
        public bool? EstaActivo { get; set; }
    }
}