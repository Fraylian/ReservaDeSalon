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

            if (login.Correo == "Fray@gmail.com" && login.Password == "1234")
            {
                seccionDTO.Nombre = "admin";
                seccionDTO.Correo = login.Correo;
                seccionDTO.Rol = "Administrador";
            }
            else
            {
                seccionDTO.Nombre = "empleado";
                seccionDTO.Correo = login.Correo;
                seccionDTO.Rol = "Empleado";
            }

            return StatusCode(StatusCodes.Status200OK, seccionDTO);
        }


    }
}
