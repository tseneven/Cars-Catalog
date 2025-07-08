using API.Repositorys.Catalog;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Classes;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalog_Repositorycs _catalog_Repository;
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ICatalog_Repositorycs catalog_repository, ILogger<CatalogController> logger)
        {
            _catalog_Repository = catalog_repository;
            _logger = logger;
        }

        [HttpGet("getallcars")]
        public async Task<ActionResult> GetAllCars()
        {
            var result = await _catalog_Repository.GetAllCars();
            return Ok(result);
        }

    }
}
