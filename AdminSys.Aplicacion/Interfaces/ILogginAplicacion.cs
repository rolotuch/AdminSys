using AdminSys.Aplicacion.Comunes.Bases;
using AdminSys.Aplicacion.Dtos.Usuario.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSys.Aplicacion.Interfaces
{
    public interface ILogginAplicacion
    {
        Task<BaseResponse<string>> Login(TokenRequestDto requestDto/*, string authType*/);
        Task<BaseResponse<string>> GenerarToken(TokenRequestDto requestDto);
    }
}
