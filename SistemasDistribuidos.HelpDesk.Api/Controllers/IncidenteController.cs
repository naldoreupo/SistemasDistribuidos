using AutoMapper;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.DTO;
using SistemasDistribuidos.HelpDesk.Entity;
using SistemasDistribuidos.HelpDesk.Service;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;

namespace SistemasDistribuidos.HelpDesk.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncidenteController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly InterfaceIncidenteService _incidenteService;

        public IncidenteController(IMapper mapper, InterfaceIncidenteService incidenteService)
        {
            _mapper = mapper;
            _incidenteService = incidenteService;
        }

        [HttpPost]
        [Produces("application/json", Type = typeof(Response<int>))]
        public Response<int> Registrar(IncidenciaRequest incidenciaRequest)
        {
            return _incidenteService.Registrar(_mapper.Map<IncidenciaRequest, Incidencia>(incidenciaRequest)); ;
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("{idIncidencia}")]
        public Response<Incidencia> ObtenerIncidencia(int idIncidencia)
        {
            return _incidenteService.ObtenerIncidencia(idIncidencia);
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("listar")]
        public Response<Incidencia> Listar()
        {
            return _incidenteService.Listar();
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("obtenerestado/{idIncidencia}")]
        public Response<int> ObtenerEstado(int idIncidencia)
        {
            return _incidenteService.ObtenerEstado(idIncidencia);
        }

        [HttpDelete]
        [Route("anular/{idIncidencia}")]
        public Response<int> Anular(int idIncidencia)
        {
            return _incidenteService.Anular(idIncidencia);
        }

        [HttpPut]
        [Route("escalarext")]
        public Response<int> EscalarProvExterno(MovimientoProveedorRequest movimiento)
        {
            return _incidenteService.EscalarProvExt(_mapper.Map<MovimientoProveedorRequest, MovimientoProveedor>(movimiento));
        }

        [HttpPut]
        [Route("escalarint")]
        public Response<int> EscalarInt(MovimientoUsuarioRequest movimiento)
        {
            return _incidenteService.EscalarInt(_mapper.Map<MovimientoUsuarioRequest, MovimientoUsuario>(movimiento));
        }

        [HttpPut]
        [Route("derivar")]
        public Response<int> Derivar(MovimientoUsuarioRequest movimiento)
        {
            return _incidenteService.Derivar(_mapper.Map<MovimientoUsuarioRequest, MovimientoUsuario>(movimiento));
        }

        [HttpPut]
        [Route("reabrir/{idIncidencia}")]
        public Response<int> Reabrir(int idIncidencia)
        {
            return _incidenteService.Reabrir(idIncidencia);
        }

        [HttpPost]
        [Produces("application/json", Type = typeof(Response<int>))]
        [Route("solicitarEscalamiento")]
        public Response<int> SolicitarEscalamiento(SolicitudSupervisorRequest solicitud)
        {
            return _incidenteService.SolicitarEscalamiento(_mapper.Map<SolicitudSupervisorRequest, SolicitudSupervisor>(solicitud));
        }

        [HttpPut]
        [Route("autorizar")]
        public Response<int> Autorizar(int idMovimiento)
        {
            return _incidenteService.Autorizar(idMovimiento);
        }

        [HttpGet]
        [Route("cerrar/{idIncidencia}")]
        public Response<int> Cerrar(int idIncidencia)
        {
            return _incidenteService.Cerrar(idIncidencia);
        }
    }
}
