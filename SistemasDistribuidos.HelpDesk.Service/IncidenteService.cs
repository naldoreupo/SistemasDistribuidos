using SistemasDistribuidos.HelpDesk.Config;
using SistemasDistribuidos.HelpDesk.DAO;
using SistemasDistribuidos.HelpDesk.Entity;
using System;
using System.Collections.Generic;

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
                Message = "Se encontró el estado actual de la incidencia",
                Data = (int)incidencia.Data.IdEstado
            };
        }


        public Response<int> EscalarInt(MovimientoUsuario movimiento)
        {
            return _interfaceIncidenteRepository.EscalarInt(movimiento);
        }


        public Response<int> Derivar(MovimientoUsuario movimiento)
        {
            return _interfaceIncidenteRepository.Derivar(movimiento);
        }

        public Response<Incidencia> ObtenerIncidencia(int idIncidencia)
        {
            return _interfaceIncidenteRepository.Obtener(idIncidencia);
        }

        public Response<int> Reabrir(int idIncidencia)
        {
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);

            if (incidencia.Status)
            {
                incidencia.Data.EstaActivo = true;
                incidencia.Data.CheckAnulacion = false;

                return _interfaceIncidenteRepository.Reabrir(incidencia.Data);
            }

            return new Response<int>
            {
                Status = false,
                Message = "El IdIncidencia no se encuentra en la base de datos"
            };
        }
        public Response<int> SolicitarEscalamiento(int idIncidencia)
        {
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);

            if (incidencia.Status)
            {
                return _interfaceIncidenteRepository.SolicitarEscalamiento(incidencia.Data);
            }

            return new Response<int>
            {
                Status = false,
                Message = "El IdIncidencia no se encuentra en la base de datos"
            };
        }
        public Response<int> Autorizar(int idIncidencia)
        {
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);

            if (incidencia.Status)
            {
                return _interfaceIncidenteRepository.Autorizar(incidencia.Data);
            }

            return new Response<int>
            {
                Status = false,
                Message = "El IdIncidencia no se encuentra en la base de datos"
            };
        }

        public Response<Incidencia> Listar()
        {
            var incidencia = _interfaceIncidenteRepository.Listar();

            if (incidencia.Status)
            {
                return _interfaceIncidenteRepository.Listar();
            }

            return new Response<Incidencia>
            {
                Status = false,
                Message = "El IdIncidencia no se encuentra en la base de datos"
            };
        }

        public Response<int> Cerrar(int idIncidencia)
        {
            var incidencia = _interfaceIncidenteRepository.Obtener(idIncidencia);


            if (incidencia.Status)
            {
                incidencia.Data.EstaActivo = false;

                return _interfaceIncidenteRepository.Cerrar(incidencia.Data);
            }

            return new Response<int>
            {
                Status = false,
                Message = "La incidencia no se encuentra"
            };

        }
    }
}
