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

        public async Task<List<Car_Model>> GetUserCars(int id)
        {
            return await _HttpClient.GetFromJsonAsync<List<Car_Model>>($"http://localhost:8000/api/Catalog/getusercars?id={id}") ?? new List<Car_Model>();
        }

        public async Task<string> AddCar(Car_Model car_Model)
        {
            try
            {
                var response = await _HttpClient.PostAsJsonAsync($"http://localhost:8000/api/Catalog/addcar", car_Model);

                return ((int)response.StatusCode).ToString();

            }
            catch
            {
                return "500";
            }
        }

        public async Task<string> DeleteCar(int id)
        {
            try
            {
                var response = await _HttpClient.DeleteAsync($"http://localhost:8000/api/Catalog/deletecar?id={id}");
                return ((int)response.StatusCode).ToString();
            }
            catch
            {
                return "500";
            }
        }

        public async Task<string> EditCar(Car_Model car_Model)
        {
            try
            {
                var response = await _HttpClient.PatchAsJsonAsync($"http://localhost:8000/api/Catalog/editcar", car_Model);
                return ((int)response.StatusCode).ToString();
            }
            catch 
            {
                return "500";
            }
        }
    }
}
