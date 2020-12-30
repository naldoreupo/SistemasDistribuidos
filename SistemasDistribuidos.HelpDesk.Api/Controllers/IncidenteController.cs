using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.DTO;
using SistemasDistribuidos.HelpDesk.Entity;
using SistemasDistribuidos.HelpDesk.Service;
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
        public Response<int> Registrar(IncidenciaRequest incidenciaRequest)
        {
            return _incidenteService.Registrar(_mapper.Map<IncidenciaRequest, Incidencia>(incidenciaRequest)); ;
        }

        [HttpPut]
        [Route("anular/{idIncidencia}")]
        public Response<int> Anular(int idIncidencia)
        {
            return _incidenteService.Anular(idIncidencia);
        }

        [HttpPost]
        [Route("escalarext")]
        public Response<int> EscalarProvExterno(MovimientoProveedorRequest movimiento)
        {
            return _incidenteService.EscalarProvExt(_mapper.Map<MovimientoProveedorRequest, MovimientoProveedor>(movimiento));
        }

        [HttpGet]
        [Route("obtenerestado/{idIncidencia}")]
        public Response<int> ObtenerEstado(int idIncidencia)
        {
            return _incidenteService.ObtenerEstado(idIncidencia);
        }

        [HttpPut]
        [Route("reabrir/{idIncidencia}")]
        public Response<int> Reabrir(int idIncidencia)
        {
            return _incidenteService.Reabrir(idIncidencia);
        }

        [HttpPut]
        [Route("solicitarEscalamiento/{idIncidencia}")]
        public Response<int> SolicitarEscalamiento(int idIncidencia)
        {
            return _incidenteService.SolicitarEscalamiento(idIncidencia);
        }

        [HttpPut]
        [Route("autorizar/{idIncidencia}")]
        public Response<int> Autorizar(int idIncidencia)
        {
            return _incidenteService.Autorizar(idIncidencia);
        }

        [HttpGet]
        [Route("listar")]
        public Response<List<Incidencia>> Listar()
        {
            return _incidenteService.Listar();
        }
    }
}
