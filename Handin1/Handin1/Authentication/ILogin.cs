using Models;

namespace Handin1.Authentication {
    public interface ILogin {
        User Validate(string username, string password);
    }
}