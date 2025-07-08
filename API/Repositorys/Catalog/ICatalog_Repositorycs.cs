using Classes;

namespace API.Repositorys.Catalog
{
    public interface ICatalog_Repositorycs
    {
        public Task<List<Car_Model>> GetAllCars();
        public Task<string> AddCar(Car_Model car_Model);
        public Task<string> DeleteCar(int id);
        public Task<string> UpdateCar(Car_Model car_Model);
    }
}
