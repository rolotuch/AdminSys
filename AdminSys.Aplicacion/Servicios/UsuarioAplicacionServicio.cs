using AdminSys.Aplicacion.Comunes.Bases;
using AdminSys.Aplicacion.Dtos.Usuario.Request;
using AdminSys.Aplicacion.Dtos.Usuario.response;
using AdminSys.Aplicacion.Interfaces;
using AdminSys.Dominio.Entities;
using AdminSys.Infraestructura.Commons.Bases.Response;
using AdminSys.Infraestructura.Comunes.Bases.Request;
using AdminSys.Infraestructura.Persistencia.Interfaces;
using AdminSys.Utilidades.Static;
using AutoMapper;
using Azure.Storage.Blobs.Models;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using WatchDog;
using BC = BCrypt.Net.BCrypt;

namespace AdminSys.Aplicacion.Servicios
{
    public class UsuarioAplicacionServicio : IAplicacionUsuario
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuracion;
        private readonly IValidator<UserRequestDto> _validator;
        public UsuarioAplicacionServicio(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuracion, IValidator<UserRequestDto> validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuracion = configuracion;
            _validator = validator;
        }

        public async Task<BaseResponse<BaseEntityResponse<UsuarioResponseDto>>> ListUsuario(BaseFiltersRequest filtros)
        {
            var response = new BaseResponse<BaseEntityResponse<UsuarioResponseDto>>();
            try
            {
                var usuario = await _unitOfWork.AdUsuario.ListUsuario(filtros);
                //validaciones
                if (usuario is not null)
                {
                    response.IsSucces = true;
                    response.Data = _mapper.Map<BaseEntityResponse<UsuarioResponseDto>>(usuario);
                    response.Mensaje = MensajeRespuesta.MENSAJE_CONSULTA;
                }
                else
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_CONSULTA_VACIO;
                }
            }
            catch (Exception ex)
            {

                response.IsSucces = false;
                response.Mensaje = MensajeRespuesta.MENSAJE_EXEPCION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }
        public async Task<BaseResponse<IEnumerable<UsuarioSelectResponseDto>>> ListSelectUsuario()
        {
            var response = new BaseResponse<IEnumerable<UsuarioSelectResponseDto>>();
            //cambiamos los metodos por los del repositorio generico

            try
            {
                var usuario = await _unitOfWork.AdUsuario.GetAllAsync(); //al principio da error porque no hemos heredado del repositorio generico, vamos a la interface ICategoriaRepositorio

                if (usuario is not null)
                {
                    response.IsSucces = true;
                    response.Data = _mapper.Map<IEnumerable<UsuarioSelectResponseDto>>(usuario);
                    response.Mensaje = MensajeRespuesta.MENSAJE_CONSULTA;
                }
                else
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_CONSULTA_VACIO;
                }
            }
            catch (Exception ex)
            {

                response.IsSucces = false;
                response.Mensaje = MensajeRespuesta.MENSAJE_EXEPCION;
                WatchLogger.Log(ex.Message);
            }


            return response;
        }

        public async Task<BaseResponse<UsuarioResponseDto>> UsuarioById(string usuarioId)
        {
            var response = new BaseResponse<UsuarioResponseDto>();
            try
            {
                var usuario = await _unitOfWork.AdUsuario.GetByIdAsync(usuarioId);

                if (usuario is not null)
                {
                    response.IsSucces = true;
                    response.Data = _mapper.Map<UsuarioResponseDto>(usuario);
                    response.Mensaje = MensajeRespuesta.MENSAJE_CONSULTA;
                }
                else
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_CONSULTA_VACIO;
                }
            }
            catch (Exception ex)
            {

                response.IsSucces = false;
                response.Mensaje = MensajeRespuesta.MENSAJE_EXEPCION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse<bool>> RegisterUser(UserRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var account = _mapper.Map<AdUsuario>(requestDto);

                account.Id = account.Id!.ToUpper();
                account.Password2 = account.Password2!.ToUpper();
                account.Email = account.Email!.ToUpper();
                account.Nombre = account.Nombre!.ToUpper();
                account.Puesto = account.Puesto.ToUpper();
                account.Directiva = account.Directiva!.ToUpper();
                account.SesionMultiple = account.SesionMultiple!.ToUpper();
                account.MeEstado = account.MeEstado!.ToUpper();

                account.Password2 = BC.HashPassword(account.Password2);                
                response.Data = await _unitOfWork.AdUsuario.RegisterAsync(account);

                if (response.Data)
                {
                    response.IsSucces = true;
                    response.Mensaje = MensajeRespuesta.MENSAJE_GUARDAR;
                }
                else
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_FALLIDO;
                }
            }
            catch (Exception ex)
            {
                response.IsSucces = false;
                response.Mensaje = MensajeRespuesta.MENSAJE_EXEPCION;
                WatchLogger.Log(ex.Message);
            }
            return response;
        }

        public async Task<BaseResponse<bool>> EditarUsuario(string usuarioId, UserRequestUpdateDto requestUpdateDto)
        {
            // UpdateAsync
            var response = new BaseResponse<bool>();
            try
            {
                var usuarioEdit = await UsuarioById(usuarioId);

                if (usuarioEdit.Data is null)
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_CONSULTA_VACIO;
                }

                var usuario = _mapper.Map<AdUsuario>(requestUpdateDto);
                usuario.Id = usuarioId;
               
                usuario.Email = usuario.Email!.ToUpper();
                usuario.Nombre = usuario.Nombre!.ToUpper();
                usuario.Puesto = usuario.Puesto.ToUpper();
                usuario.Directiva = usuario.Directiva!.ToUpper();
                usuario.SesionMultiple = usuario.SesionMultiple!.ToUpper();
                usuario.MeEstado = usuario.MeEstado!.ToUpper();

                response.Data = await _unitOfWork.AdUsuario.UpdateAsync(usuario);

                if (response.Data)
                {
                    response.IsSucces = true;
                    response.Mensaje = MensajeRespuesta.MENSAJE_ACTUALIZAR;
                }
                else
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_FALLIDO;
                }
            }
            catch (Exception ex)
            {
                response.IsSucces = false;
                response.Mensaje = MensajeRespuesta.MENSAJE_EXEPCION;
                WatchLogger.Log(ex.Message);
            }
            return response;
        }

        public async Task<BaseResponse<bool>> EliminarUsuario(string usuarioId)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var usuario = await UsuarioById(usuarioId);
                if (usuario.Data is null)
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_CONSULTA_VACIO;
                }

                response.Data = await _unitOfWork.AdUsuario.DeleteAsync(usuarioId);

                if (response.Data)
                {
                    response.IsSucces = true;
                    response.Mensaje = MensajeRespuesta.MENSAJE_ELIMINAR;
                }
                else
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_FALLIDO;
                }
            }
            catch (Exception ex)
            {
                response.IsSucces = false;
                response.Mensaje = MensajeRespuesta.MENSAJE_EXEPCION;
                WatchLogger.Log(ex.Message);
            }
            return response;
        }
    }
}

