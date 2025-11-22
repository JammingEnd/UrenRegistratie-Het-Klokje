
using Klokje.Core.Models;

namespace Klokje.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Client? Login(string email, string password);
    }
}
