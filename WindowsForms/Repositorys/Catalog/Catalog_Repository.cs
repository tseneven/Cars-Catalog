using Classes;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsForms.Repositorys.Catalog
{
    public class Catalog_Repository : ICatalog_Repository
    {
        HttpClient _HttpClient = new HttpClient();
        public async Task<List<Car_Model>> GetAllCars()
        {
            return await _HttpClient.GetFromJsonAsync<List<Car_Model>>("http://localhost:8000/api/Catalog/getallcars") ?? new List<Car_Model>();
        }
    }
}
