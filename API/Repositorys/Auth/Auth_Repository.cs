using Classes;
using Microsoft.Data.SqlClient;
using System.Data;

namespace API.Repositorys.Auth
{
    public class Auth_Repository : IAuth_Repository
    {
        string connect;

        public Auth_Repository(IConfiguration configuration)
        {
            connect = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<string> Register(Auth_Model auth_model)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                await conn.OpenAsync();

                // Проверка: есть ли такой логин
                string checkQuery = "SELECT COUNT(*) FROM dbo.Users WHERE Логин = @login";
                using var checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@login", auth_model.Login);

                int count = (int)await checkCmd.ExecuteScalarAsync();

                if (count > 0)
                    return "400"; // пользователь уже есть

                // Вставка нового пользователя
                string insertQuery = "INSERT INTO dbo.Users (Логин, Пароль) VALUES (@login, @password)";
                using var insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@login", auth_model.Login);
                insertCmd.Parameters.AddWithValue("@password", auth_model.Password);

                int rows = await insertCmd.ExecuteNonQueryAsync();

                return rows > 0 ? "200" : "500";
            }
        }
        public async Task<string> Authetification(Auth_Model auth_Model)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                await conn.OpenAsync();

                string query = $"SELECT * FROM dbo.Users WHERE Логин = '{auth_Model.Login}'";

                using var queryCmd = new SqlDataAdapter(query, conn);


                DataTable db = new DataTable();

                queryCmd.Fill(db);

                if (db.Rows.Count == 0)
                {
                    return "404";
                }

                else
                {
                    if (auth_Model.Password.ToString() != db.Rows[0]["Пароль"].ToString().Trim())
                    {
                        return $"401";
                    }
                    return $"{db.Rows[0]["ID"]}";
                }
            }
        }
    }
}
