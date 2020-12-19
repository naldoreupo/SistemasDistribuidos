using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.DTO;
using SistemasDistribuidos.HelpDesk.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public bool Registrar(IncidenteRequest incidenteRequest)
        {            
            return _incidenteService.Registrar(_mapper.Map<IncidenteRequest, Incidencia>(incidenteRequest)); ;
        }
    }
}
