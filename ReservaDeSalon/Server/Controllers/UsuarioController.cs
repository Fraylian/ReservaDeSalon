using Microsoft.AspNetCore.Mvc;
using ReservaDeSalon.Shared;

namespace ReservaDeSalon.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        [HttpPost]
        [Route("login")]

        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            SeccionDTO seccionDTO = new SeccionDTO();

            if (login.Correo == "CneAdmin@gmail.com" && login.Password == "Admin")
            {
                seccionDTO.Nombre = "Empleado";
                seccionDTO.Correo = login.Correo;
                seccionDTO.Rol = "Administrador";
            }
            else
            {
                seccionDTO.Nombre = "Empleado";
                seccionDTO.Correo = login.Correo;
                seccionDTO.Rol = "Usuario";
            }

            return StatusCode(StatusCodes.Status200OK, seccionDTO);
        }


    }
}
