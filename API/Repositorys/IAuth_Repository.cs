using Classes;

namespace API.Reposirotys
{
    public interface IAuth_Repository
    {
        Task<string> Register(Auth_Model auth_model);
        Task<string> Authetification(Auth_Model auth_model);
        void Delete(string username, string password);
    }
}
