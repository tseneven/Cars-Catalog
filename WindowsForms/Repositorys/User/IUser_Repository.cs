using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Repositorys.User
{
    public interface IUser_Repository
    {
        Task<string> Delete(int id, string password);

        Task<User_Model> GetUser(int id);

        Task<string> Edit(int id, User_Model user_model);

    }
}
