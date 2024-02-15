using AdminSys.Aplicacion.Comunes.Bases;
using AdminSys.Aplicacion.Dtos.Usuario.Request;
using AdminSys.Aplicacion.Interfaces;
using AdminSys.Dominio.Entities;
using AdminSys.Infraestructura.Persistencia.Interfaces;
using AdminSys.Utilidades.AppConfiguracion;
using AdminSys.Utilidades.Static;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver.Core.WireProtocol.Messages;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WatchDog;
using BC = BCrypt.Net.BCrypt;


namespace AdminSys.Aplicacion.Servicios
{
    public class LogginAplicacion : ILogginAplicacion
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuracion;
        private readonly AppConfiguracion _appConfiguracion;

        public LogginAplicacion(IUnitOfWork unitOfWork,
            IConfiguration configuration, IOptions<AppConfiguracion> appConfiguracion)
        {
            _unitOfWork = unitOfWork;
            _configuracion = configuration;
            _appConfiguracion = appConfiguracion.Value;
        }

        public async Task<BaseResponse<string>> GenerarToken(TokenRequestDto requestDto)
        {
            //metodo para generar token
            var response = new BaseResponse<string>();

            try
            {
                var cuenta = await _unitOfWork.AdUsuario.CuentaByUsername(requestDto.Id!);
                if (cuenta is not null)
                {
                    if (BC.Verify(requestDto.Password2, cuenta.Password2))
                    {
                        response.IsSucces = true;
                        response.Data = GenerarToken(cuenta);
                        response.Mensaje = MensajeRespuesta.MENSAJE_CREAR_TOKEN;
                        return response;
                    }
                }
                else
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_TOKEN_ERROR;
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

        public async Task<BaseResponse<string>> Login(TokenRequestDto requestDto /*, string authType*/)
        {
            var response = new BaseResponse<string>();

            try
            {
                var user = await _unitOfWork.AdUsuario.CuentaByUsername(requestDto.Id!);

                if (user is null)
                {
                    response.IsSucces = false;
                    response.Mensaje = MensajeRespuesta.MENSAJE_TOKEN_ERROR;
                    return response;
                }

                //if (user.AuthType != authType)
                //{
                //    response.IsSucces = false;
                //    response.Mensaje = MensajeRespuesta.MESSAGE_AUTH_TYPE_GOOGLE;
                //    return response;
                //}

                if (BC.Verify(requestDto.Password2, user.Password2))
                {
                    response.IsSucces = true;
                    response.Data = GenerarToken(user);
                    response.Mensaje = MensajeRespuesta.MENSAJE_CREAR_TOKEN;
                    return response;
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

        private string GenerarToken(AdUsuario usuario)
        {
           
            var llave = Encoding.UTF8.GetBytes(_configuracion["Jwt:Secret"]); //la clave que le pasamos aca se encuentra en la capa de api en appsettings

            var llaveSeguridad = new SymmetricSecurityKey(llave);
            //tipo de hash o criptografia
            var credenciales = new SigningCredentials(llaveSeguridad, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId, usuario.Id!),
                //new Claim(JwtRegisteredClaimNames.FamilyName, usuario.Usuario!),
                new Claim(JwtRegisteredClaimNames.GivenName, usuario.Email!),
                new Claim(JwtRegisteredClaimNames.FamilyName, usuario.Nombre!),
                //new Claim(JwtRegisteredClaimNames.UniqueName, usuario.Usuario!),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, Guid.NewGuid().ToString(), ClaimValueTypes.Integer64)
            };

            var token = new JwtSecurityToken(
                issuer: _configuracion["Jwt:Issuer"],
                audience: _configuracion["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(int.Parse(_configuracion["Jwt:Expires"])),
                notBefore: DateTime.UtcNow,
                signingCredentials: credenciales
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
