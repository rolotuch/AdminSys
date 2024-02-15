using AdminSys.Aplicacion.Dtos.Usuario.Request;
using AdminSys.Aplicacion.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminSys.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogginController : ControllerBase
    {
        private readonly ILogginAplicacion _loginAplicacion;

        public LogginController(ILogginAplicacion loginAplicacion)
        {
            _loginAplicacion = loginAplicacion;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] TokenRequestDto requestDto /*,
            [FromQuery] string authType*/)
        {
            var response = await _loginAplicacion.Login(requestDto/*, authType*/);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("Generar/Token")]
        public async Task<IActionResult> GenerarToken([FromBody] TokenRequestDto requestDto)
        {
            var response = await _loginAplicacion.GenerarToken(requestDto);
            return Ok(response);
        }

    }
}
