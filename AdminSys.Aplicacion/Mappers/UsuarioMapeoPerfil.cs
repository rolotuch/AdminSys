using AdminSys.Aplicacion.Dtos.Usuario.Request;
using AdminSys.Aplicacion.Dtos.Usuario.response;
using AdminSys.Dominio.Entities;
using AdminSys.Infraestructura.Commons.Bases.Response;
using AutoMapper;
using AdminSys.Utilidades.Static;

namespace AdminSys.Aplicacion.Mappers
{
    public class UsuarioMapeoPerfil : Profile
    {
        public UsuarioMapeoPerfil()
        {
            CreateMap<AdUsuario, UsuarioResponseDto>()
                //agreamos un nuevo miembro para agregar a repositorios genericos
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.EstadoDeUsuario, x => x.MapFrom(y => y.MeEstado!.Equals(TiposDeEstados.Activo) ? "Activo" : "Inactivo"))
                .ReverseMap();

            CreateMap<BaseEntityResponse<AdUsuario>, BaseEntityResponse<UsuarioResponseDto>>()
                .ReverseMap();

            CreateMap<UserRequestDto, AdUsuario>();
            CreateMap<UserRequestUpdateDto, AdUsuario>();

            CreateMap<TokenRequestDto, AdUsuario>();
            CreateMap<AdUsuario, UsuarioSelectResponseDto>()
                //agreamos un nuevo miembro para agregar a repositorios genericos
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .ReverseMap();
        }
    }
}
