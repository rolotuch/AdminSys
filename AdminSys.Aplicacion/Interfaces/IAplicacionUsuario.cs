using AdminSys.Aplicacion.Comunes.Bases;
using AdminSys.Aplicacion.Dtos.Usuario.Request;
using AdminSys.Aplicacion.Dtos.Usuario.response;
using AdminSys.Infraestructura.Commons.Bases.Response;
using AdminSys.Infraestructura.Comunes.Bases.Request;

namespace AdminSys.Aplicacion.Interfaces
{
    public interface IAplicacionUsuario
    {
        Task<BaseResponse<BaseEntityResponse<UsuarioResponseDto>>> ListUsuario(BaseFiltersRequest filtros);
        Task<BaseResponse<IEnumerable<UsuarioSelectResponseDto>>> ListSelectUsuario(); //en este punto debemos crear primero dentro de aplicacion=>Dtos=>Response la siguiente clase CategoriaSelectResponseDto
        Task<BaseResponse<UsuarioResponseDto>> UsuarioById(string usuarioId);
        Task<BaseResponse<bool>> RegisterUser(UserRequestDto requestDto);
        //Task<BaseResponse<string>> GenerarToken(TokenRequestDto requestDto);
        Task<BaseResponse<bool>> EditarUsuario(string usuarioId, UserRequestUpdateDto requestUpdateDto);
        Task<BaseResponse<bool>> EliminarUsuario(string usuarioId);
    }
}
