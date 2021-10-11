using Models;

namespace Handin1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}