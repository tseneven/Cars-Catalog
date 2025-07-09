using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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

        public Task<string> Edit(int id, User_Model user_model)
        {
            return null;
        }

    }
}
