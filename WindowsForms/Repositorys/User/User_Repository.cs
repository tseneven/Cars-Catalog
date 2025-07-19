using Classes;
using System.Net.Http.Json;

namespace WindowsForms.Repositorys.User
{
    public class User_Repository : IUser_Repository
    {
        HttpClient _HttpClient = new HttpClient();

        public Task<string> Delete(int id, string password)
        {
            return null;
        }

        public async Task<User_Model> GetUser(int id)
        {
            return await _HttpClient.GetFromJsonAsync<User_Model>($"http://localhost:8000/api/User/getuser?id={id}") ?? new User_Model();
        }

        public async Task<string> Edit(User_Model user_model)
        {
            try
            {
                var response = await _HttpClient.PatchAsJsonAsync("http://localhost:8000/api/User/edit", user_model);

                return ((int)response.StatusCode).ToString();

            }
            catch
            {
                return "500";
            }
        }
    }
}
