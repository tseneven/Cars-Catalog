using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace WindowsForms.Repositorys
{
    public interface IAuth_Repository
    {
        Task<string> Registration(Auth_Model auth_Model);

        Task<string> Authorization(Auth_Model auth_Model);
    }
}
