using API.Repositorys.Catalog;
using Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("addcar")]
        public async Task<ActionResult> AddCar(Car_Model car_Model)
        {
            try
            {
                _logger.LogInformation("POST запрос /api/Catalog/addcar");
                var result = await _catalog_Repository.AddCar(car_Model);
                _logger.LogInformation(result);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deletecar")]
        public async Task<ActionResult> DeleteCarByID(int id)
        {
            try
            {
                _logger.LogInformation("DELETE запрос /api/Catalog/deletecar");
                var result = await _catalog_Repository.DeleteCar(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("editcar")]
        public async Task<ActionResult> EditCar(Car_Model car_Model)
        {
            try
            {
                _logger.LogInformation("PATCH запрос /api/Catalog/editcar");
                var result = await _catalog_Repository.EditCar(car_Model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
