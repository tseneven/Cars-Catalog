using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using API.Repositorys.User;
using Classes;

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
            _logger.LogInformation($"Get запрос api/User/getuser \n id: {id}");
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

        [HttpPatch("edit")]
        public async Task<ActionResult> Edit(User_Model user_Model)
        {
            _logger.LogInformation($"Patch запрос api/User/edit \n id: {user_Model.Id}");
            try
            {
                var result = await _user_Repository.Edit(user_Model.Id, user_Model);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete")]
        public async Task<ActionResult> Delete(int id)
        {
            _logger.LogInformation($"DELETE запрос api/User/delete");

            try
            {
                var result = await _user_Repository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
