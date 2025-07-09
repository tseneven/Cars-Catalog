using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using API.Repositorys.User;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ILogger<UserController>  _logger;
        IUser_Repository _user_Repository;
        public UserController(ILogger<UserController> logger, IUser_Repository user_Repository) 
        {
            _logger = logger;
            _user_Repository = user_Repository;
        }
        [HttpGet("getuser")]
        public async Task<ActionResult> GetUser(int id)
        {
            _logger.LogInformation($"Get запрос apt/User/getuser \n id: {id}");
            try
            {
                var result = await _user_Repository.GetUser(id);
                return Ok(result);

            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }



        }
    }
}
