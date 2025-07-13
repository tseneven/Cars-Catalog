using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Classes;
using API.Repositorys.Catalog;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalog_Repository _catalog_Repository;
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ICatalog_Repository catalog_repository, ILogger<CatalogController> logger)
        {
            _catalog_Repository = catalog_repository;
            _logger = logger;
        }

        [HttpGet("getallcars")]
        public async Task<ActionResult> GetAllCars()
        {
            try
            {
                _logger.LogInformation("GET запрос /api/Catalog/getallcars");
                var result = await _catalog_Repository.GetAllCars();
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("getusercars")]
        public async Task<ActionResult> GetUserCars(int id)
        {
            try
            {
                _logger.LogInformation("GET запрос /api/Catalog/getuserscar");
                var result = await _catalog_Repository.GetUserCars(id);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
