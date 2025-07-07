using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;

namespace WindowsForms.Repositorys
{
    public interface IAuth_Repository
    {
        Task<string> Registration(Auth_Model auth_Model);
    }
}
