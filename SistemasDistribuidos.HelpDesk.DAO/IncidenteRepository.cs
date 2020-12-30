using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemasDistribuidos.HelpDesk.DAO
{
    public class IncidenteRepository : InterfaceIncidenteRepository
    {
        private readonly HelpDeskDBContext _incidenteContext;

        public IncidenteRepository(HelpDeskDBContext incidenteContext)
        {
            _incidenteContext = incidenteContext;
        }

        public Response<int> Registrar(Incidencia incidencia)
        {
            try
            {
                _incidenteContext.Incidencias.Add(incidencia);
                _incidenteContext.SaveChanges();

                return new Response<int>()
                {
                    Status = true,
                    Message = "Incidencia agregada correctamente",
                    Data = incidencia.IdIncidencia
                };
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Status = false,
                    Message = "Error al intentar agregar incidencia - " + ex.Message,
                    Data = 0
                };
            }
        }

        public Response<int> Anular(Incidencia incidencia)
        {
            try
            {
                _incidenteContext.Incidencias.Update(incidencia);
                _incidenteContext.SaveChanges();

                return new Response<int>()
                {
                    Status = true,
                    Message = "Incidencia anulada correctamente",
                    Data = incidencia.IdIncidencia
                };
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Status = false,
                    Message = "Error al intentar anular la incidencia - " + ex.Message,
                    Data = 0
                };
            }
        }

        public Response<Incidencia> Obtener(int id)
        {
            Incidencia incidencia = _incidenteContext.Incidencias.Find(id);

            if (incidencia == null)
            {
                return new Response<Incidencia>()
                {
                    Status = false,
                    Message = "No se encontró una incidencia con el id enviado."
                };
            }

            return new Response<Incidencia>()
            {
                Status = true,
                Message = "Incidencia obtenida correctamente",
                Data = incidencia
            };
        }

        public Response<int> EscalarProvExt(MovimientoProveedor movimiento)
        {
            try
            {
                var incidencia = _incidenteContext.Incidencias.Find(movimiento.IdIncidencia);

                incidencia.IdEstado = 5;

                _incidenteContext.Incidencias.Update(incidencia);
                _incidenteContext.MovimientosDeProveedor.Add(movimiento);
                _incidenteContext.SaveChanges();

                return new Response<int>()
                {
                    Status = true,
                    Message = "Se escaló a proveedor externo correctamente",
                    Data = incidencia.IdIncidencia
                };
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Status = false,
                    Message = "Error al intentar escalar la incidencia " + ex.Message,
                    Data = 0
                };
            }
        }


        public Response<int> EscalarInt(MovimientoUsuario movimiento)
		{
            try
            {
                var incidencia = _incidenteContext.Incidencias.Find(movimiento.IdIncidencia);
                incidencia.IdEstado = 4; // Escalado Interno
                
                _incidenteContext.Incidencias.Update(incidencia);

                if (!movimiento.FechaRegistro.HasValue)
                    movimiento.FechaRegistro = DateTime.Now;
                if (movimiento.Correlativo == null)
                    movimiento.Correlativo = 1;
                movimiento.EstaActivo = true;
                _incidenteContext.MovimientoUsuario.Add(movimiento);
                _incidenteContext.SaveChanges();

                return new Response<int>()
                {
                    Status = true,
                    Message = "Se escaló internamente correctamente ",
                    Data = 0
                };
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Status = false,
                    Message = "Error al intentar escalar la incidencia " + ex.Message,
                    Data = 0
                };
            }
        }

		public Response<int> Derivar(MovimientoUsuario movimiento)
		{
            try
            {
                var incidencia = _incidenteContext.Incidencias.Find(movimiento.IdIncidencia);
                incidencia.IdEstado = 3; // Derivado

                _incidenteContext.Incidencias.Update(incidencia);

                if (!movimiento.FechaRegistro.HasValue)
                    movimiento.FechaRegistro = DateTime.Now;
                if (movimiento.Correlativo == null)
                    movimiento.Correlativo = 1;
                movimiento.EstaActivo = true;
                _incidenteContext.MovimientoUsuario.Add(movimiento);
                _incidenteContext.SaveChanges();

                return new Response<int>()
                {
                    Status = true,
                    Message = "Se derivó correctamente ",
                    Data = 0
                };
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Status = false,
                    Message = "Error al intentar derivar la incidencia " + ex.Message,
                    Data = 0
                };
            }
        }



        public Response<int> Reabrir(Incidencia incidencia)
        {
            try
            {

                _incidenteContext.Incidencias.Update(incidencia);
                _incidenteContext.SaveChanges();

                return new Response<int>()
                {
                    Status = true,
                    Message = "Incidencia reabierta correctamente",
                    Data = incidencia.IdIncidencia
                };
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Status = false,
                    Message = "Error al intentar anular la incidencia " + ex.Message,
                    Data = 0
                };
            }
        }

        public Response<int> SolicitarEscalamiento(Incidencia incidencia)
        {
            try
            {
                _incidenteContext.Incidencias.Update(incidencia);
                _incidenteContext.SaveChanges();

                return new Response<int>()
                {
                    Status = true,
                    Message = "Escalamiento solicitado correctamente",
                    Data = incidencia.IdIncidencia
                };
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Status = false,
                    Message = "Error al intentar solicitar escalamiento" + ex.Message,
                    Data = 0
                };
            }
        }

        public Response<int> Autorizar(Incidencia incidencia)
        {
            try
            {
                _incidenteContext.Incidencias.Update(incidencia);
                _incidenteContext.SaveChanges();

                return new Response<int>()
                {
                    Status = true,
                    Message = "Incidencia autorizada correctamente",
                    Data = incidencia.IdIncidencia
                };
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Status = false,
                    Message = "Error al intentar autorizar la incidencia " + ex.Message,
                    Data = 0
                };
            }
        }

        public Response<List<Incidencia>> Listar()
        {
            try
            {
                var incidencias = _incidenteContext.Incidencias.Where(i => true).ToList();
                _incidenteContext.SaveChanges();

                return new Response<List<Incidencia>>()
                {
                    Status = true,
                    Message = "Incidencias listadas correctamente",
                    Data = incidencias
                };
            }
            catch (Exception ex)
            {
                return new Response<List<Incidencia>>()
                {
                    Status = false,
                    Message = "Error al intentar listar las incidencias " + ex.Message,
                    Data = null
                };
            }
        }

    }
}
