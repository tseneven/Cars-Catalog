using Classes;

namespace API.Repositorys.Catalog
{
    public interface ICatalog_Repository
    {
        public Task<List<Car_Model>> GetAllCars();
        public Task<List<Car_Model>> GetUserCars(int id);
        public Task<string> AddCar(Car_Model car_Model);
        public Task<string> DeleteCar(int id);
        public Task<string> EditCar(Car_Model car_Model);
    }
}
