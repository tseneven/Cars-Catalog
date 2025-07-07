using API.Models;

namespace API.Reposirotys
{
    public interface IAuth_Repository
    {
        Task<string> Register(Auth_Model auth_model);
        void Authetification(string username, string password);
        void Delete(string username, string password);
    }
}
