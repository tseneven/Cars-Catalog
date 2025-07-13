using Classes;
using Microsoft.Data.SqlClient;
using System.Data;

namespace API.Repositorys.Catalog
{
    public class Catalog_Repository : ICatalog_Repository
    {
        string connect;

        public Catalog_Repository(IConfiguration configuration)
        {
            connect = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<Car_Model>> GetAllCars()
        {
            var cars = new List<Car_Model>();

            using (SqlConnection conn = new SqlConnection(connect))
            {
                await conn.OpenAsync();
                string query = "SELECT * FROM dbo.Cars";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var car = new Car_Model
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            Name = reader["Название"].ToString().Trim(),
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Years = reader["Год выпуска"].ToString().Trim(),
                            Mileage = reader["Пробег"].ToString().Trim(),
                            Technical_Сondition = reader["Техническое состояние"].ToString().Trim(),
                            image = reader["image"] != DBNull.Value ? (byte[])reader["image"] : null,
                            Price = reader["Цена"].ToString().Trim()
                        };
                        cars.Add(car);
                    }
                }
            }
            return cars;
        }

        public Task<string> AddCar(Car_Model car_Model)
        {
            return null;
        }
        public Task<string> DeleteCar(int id)
        {
            return null;
        }
        public Task<string> UpdateCar(Car_Model car_Model)
        {
            return null;
        }

        public async Task<List<Car_Model>> GetUserCars(int id)
        {
            var cars = new List<Car_Model>();

            using (SqlConnection conn = new SqlConnection(connect))
            {
                await conn.OpenAsync();
                string query = $"SELECT * FROM dbo.Cars WHERE UserID = {id}";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var car = new Car_Model
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            Name = reader["Название"].ToString().Trim(),
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Years = reader["Год выпуска"].ToString().Trim(),
                            Mileage = reader["Пробег"].ToString().Trim(),
                            Technical_Сondition = reader["Техническое состояние"].ToString().Trim(),
                            image = reader["image"] != DBNull.Value ? (byte[])reader["image"] : null,
                            Price = reader["Цена"].ToString().Trim()
                        };
                        cars.Add(car);
                    }
                }
            }
            return cars;

        }
    }
}
