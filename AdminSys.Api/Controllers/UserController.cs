using AdminSys.Aplicacion.Dtos.Usuario.Request;
using AdminSys.Aplicacion.Interfaces;
using AdminSys.Infraestructura.Comunes.Bases.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminSys.Api.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAplicacionUsuario _aplicacionUsuario;
        public UserController(IAplicacionUsuario aplicacionUsuario)
        {
            _aplicacionUsuario = aplicacionUsuario;
        }


        //listar usuario
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ListUsuario([FromBody] BaseFiltersRequest filtros)
        {
            var response = await _aplicacionUsuario.ListUsuario(filtros);
            return Ok(response);
        }

        //select usuario 
        [HttpGet("Select")]
        [AllowAnonymous]
        public async Task<IActionResult> ListSelectUsuario()
        {
            var response = await _aplicacionUsuario.ListSelectUsuario();
            return Ok(response);
        }

        //usuario por Id
        [AllowAnonymous]
        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> UsuarioById(string usuarioId)
        {
            var response = await _aplicacionUsuario.UsuarioById(usuarioId);
            return Ok(response);
        }



        [AllowAnonymous]
        [HttpPost("Registrar")]

        public async Task<IActionResult> RegistrarUsuario([FromBody] UserRequestDto requestDto)
        {
            var response = await _aplicacionUsuario.RegisterUser(requestDto);
            return Ok(response);
        }

        [HttpPut("Edit/{usuarioId}")]
        public async Task<IActionResult> EditarUsuario(string usuarioId, [FromBody] UserRequestUpdateDto requestUpdateDto)
        {
            var response = await _aplicacionUsuario.EditarUsuario(usuarioId, requestUpdateDto);
            return Ok(response);
        }

        [HttpPut("Eliminar/{usuarioId}")]
        public async Task<IActionResult> EliminarUsuario(string usuarioId)
        {
            var response = await _aplicacionUsuario.EliminarUsuario(usuarioId);
            return Ok(response);
        }



        
    }
}
