using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Repositorys
{
    public class Auth_Reposirtory : IAuth_Repository
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<string> Registration(Auth_Model auth_Model)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:8000/api/Auth/register", auth_Model);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            else return (response.StatusCode).ToString();
        }

        public async Task<string> Authorization(Auth_Model auth_Model)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:8000/api/Auth/authorization", auth_Model);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            else return (response.StatusCode).ToString();
        }
    }
}
