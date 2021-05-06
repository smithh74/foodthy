using FoodThy.Application.Interfaces;
using FoodThy.Application.Models;
using FoodThy.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodThy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUser _user;
        public AccountController(IUser user)
        {
            _user = user;  
        }

        [HttpPost(Name = nameof(CreateUser))]
        public async Task<IActionResult> CreateUser(UserDto user)
        {
            var userBd = new TblUsuario();
            userBd.Nombres = user.Nombres;
            userBd.Apellidos = user.Apellidos;
            userBd.Correo = user.Correo;
            userBd.Contrasena = user.Contrasena;
            userBd.PendienteConfirmar = true;
            userBd.Estado = true;

            await _user.CreateUser(userBd);

            return Ok();
        }

        [HttpGet(Name = nameof(GetUsers))]
        public async Task<IActionResult> GetUsers()
        {
            var user = await _user.GetUsers();
            return Ok(user);
        }

    }
}
