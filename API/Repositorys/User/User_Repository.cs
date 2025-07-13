using Classes;
using Microsoft.Data.SqlClient;
using System;

namespace API.Repositorys.User
{
    public class User_Repository : IUser_Repository
    {
        string connect;

        public User_Repository(IConfiguration configuration)
        {
            connect = configuration.GetConnectionString("DefaultConnection");
        }

        public Task<string> Delete(int id, string password)
        {
            return null;
        }

        public async Task<User_Model> GetUser(int id)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                await conn.OpenAsync();

                string query = $"SELECT Имя, Телефон FROM dbo.Users WHERE ID = {id}";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    await reader.ReadAsync();

                    
                    return new User_Model
                    {
                        Name = reader["Имя"].ToString(),
                        telephone = reader["Телефон"].ToString()
                    };
                }
            }
        }

        public async Task<string> Edit(int id, User_Model user_model)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                await conn.OpenAsync();

                string query = $"UPDATE dbo.Users SET Имя = '{user_model.Name}', Телефон = '{user_model.telephone}' WHERE ID = {user_model.Id}";

                SqlCommand sqlCommand = new SqlCommand(query, conn);

                int rows = await sqlCommand.ExecuteNonQueryAsync();

                return rows > 0 ? "200" : "500";
            }
        }

    }
}
