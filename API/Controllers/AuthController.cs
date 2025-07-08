using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Classes;
using API.Repositorys.Auth;

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
            _logger.LogInformation($"Post запрос /api/Auth/register \n{result} \n{auth_model.Login} \n{auth_model.Password}");

            return result switch
            {
                "200" => Ok("200"),
                "400" => StatusCode(400, "400"),
                _ => StatusCode(500, "500")
            };
        }

        [HttpPost("authorization")]
        public async Task<ActionResult> Authorization([FromBody] Auth_Model auth_model)
        {
            var result = await _authRepository.Authetification(auth_model);
            _logger.LogInformation($"Post запрос /api/Auth/authorization \n{result} \n{auth_model.Login} \n{auth_model.Password}");

            return result switch
            {
                "200" => Ok("200"),
                "404" => StatusCode(404, "404"),
                "401" => StatusCode(401, "401"),
                _ => StatusCode(500, "500")
            };
        }
    }
}
