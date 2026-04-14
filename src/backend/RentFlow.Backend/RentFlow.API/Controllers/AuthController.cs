using Microsoft.AspNetCore.Mvc;
using RentFlow.Application.Interfaces;
using RentFlow.Application.DTOs;
using static RentFlow.Application.DTOs.AuthDto;

namespace RentFlow.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthController(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Por ahora, validaremos un usuario de prueba para testear el Token.
            if (request.Email == "admin@bridgebyte.com" && request.Password == "Admin123!")
            {
                // Simulamos datos que vendrían de la DB
                var userId = Guid.NewGuid();
                var tenantId = Guid.NewGuid(); // El ID del negocio del usuario

                var token = _jwtTokenGenerator.GenerateToken(userId, request.Email, "Admin", tenantId);

                return Ok(new LoginResponse(token, request.Email));
            }

            return Unauthorized("Credenciales inválidas");
        }
    }
}
