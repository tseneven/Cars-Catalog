using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Repositorys.Catalog
{
    public interface ICatalog_Repository
    {
        Task<List<Car_Model>> GetAllCars();
        Task<List<Car_Model>> GetUserCars(int id);
    }
}
