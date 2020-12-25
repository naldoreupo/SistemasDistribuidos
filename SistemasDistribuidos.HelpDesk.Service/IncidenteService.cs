using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.Entity;
using System;

namespace SistemasDistribuidos.HelpDesk.Service
{
    public class IncidenteService : InterfaceIncidenteService
    {
        private readonly InterfaceIncidenteRepository _interfaceIncidenteRepository;

        public IncidenteService(InterfaceIncidenteRepository interfaceIncidenteRepository)
        {
            _interfaceIncidenteRepository = interfaceIncidenteRepository;
        }

        public Response<int> Anular(int idIncidencia)
        {
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);

            if (incidencia.Status)
            {
                incidencia.Data.FechaAnulacion = DateTime.Now;
                incidencia.Data.CheckAnulacion = true;

                return _interfaceIncidenteRepository.Anular(incidencia.Data);
            }

            return new Response<int>
            {
                Status = false,
                Message = "El IdIncidencia no se encuentra en la base de datos"
            };
        }

        public Response<int> Registrar(Incidencia incidencia)
        {
            return _interfaceIncidenteRepository.Registrar(incidencia);
        }

        public Response<int> EscalarProvExt(MovimientoProveedor movimiento)
        {
            return _interfaceIncidenteRepository.EscalarProvExt(movimiento);
        }

        public Response<int> ObtenerEstado(int idIncidencia)
        {
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);

            return new Response<int>
            {
                Status = true,
                Message = "Se encontró el estado actual de la incidencia 1",
                Data = (int)incidencia.Data.IdEstado
            };
        }

        public Response<int> EscalarInt(int idIncidencia)
        {
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);
            return new Response<int>
            {
                Status = true,
                Message = "Escalar internamente",
                Data = incidencia.Data.IdIncidencia
            };
            //return _interfaceIncidenteRepository.EscalarInt(incidencia);
        }

        public Response<int> Derivar(int idIncidencia)
        {
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);
            return new Response<int>
            {
                Status = true,
                Message = "Derivar",
                Data = incidencia.Data.IdIncidencia
            };
            //return _interfaceIncidenteRepository.Derivar(incidencia);
        }

		public Response<int> ObtenerIncidencia(int idIncidencia)
		{
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);
            return new Response<int>
            {
                Status = true,
                Message = "Se encontró el estado actual de la incidencia 3",
                Data = incidencia.Data.IdIncidencia
            };
        }
	}
}
