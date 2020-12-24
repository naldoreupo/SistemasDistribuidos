using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.DTO;
using SistemasDistribuidos.HelpDesk.Entity;
using SistemasDistribuidos.HelpDesk.Service;

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
        [Route("obtener/{incidencia}")]
        public Response<int> ObtenerInc(int idIncidencia)
        {
            return _incidenteService.ObtenerInc(idIncidencia);
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

        [HttpPost]
        [Route("escalarint")]
        public Response<int> EscalarInt(IncidenciaRequest incidenciaRequest)
        {
            return _incidenteService.EscalarInt(_mapper.Map<IncidenciaRequest, Incidencia>(incidenciaRequest));
        }

        [HttpPost]
        [Route("derivar")]
        public Response<int> Derivar(IncidenciaRequest incidenciaRequest)
        {
            return _incidenteService.EscalarInt(_mapper.Map<IncidenciaRequest, Incidencia>(incidenciaRequest));
        }


        [HttpGet]
        [Route("obtenerestado/{idIncidencia}")]
        public Response<int> ObtenerEstado(int idIncidencia)
        {
            return _incidenteService.ObtenerEstado(idIncidencia);
        }
    }
}
