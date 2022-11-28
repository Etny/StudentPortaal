using PortaalBackend.Domain.Models;

namespace PortaalBackend.Domain.Interfaces
{
    public interface IUserService
    {
        public Task<User> CreateUser(User user);
        public User GetUserByEmail(string email);
    }
}
