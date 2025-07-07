using API.Models;
using API.Reposirotys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth_Repository _authRepository;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuth_Repository authRepository, ILogger<AuthController> logger)
        {
            _authRepository = authRepository;
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] Auth_Model auth_model)
        {
            var result = await _authRepository.Register(auth_model);
            _logger.LogInformation($"Post запрос /api/Auth/register \n{auth_model.Login} \n{auth_model.Password}");

            return result switch
            {
                "200" => Ok(auth_model),
                "400" => StatusCode(400, "Пользователь уже существует"),
                _ => StatusCode(500, "Ошибка на сервере")    
            };
            
        }
    }
}
