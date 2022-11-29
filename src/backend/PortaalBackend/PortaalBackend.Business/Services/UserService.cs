using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models;

namespace PortaalBackend.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;

        public UserService(IRepository<User> repository)
        {
            this.repository = repository;
        }

        public async Task<User> CreateUser(User user)
        {
            User createdUser = await repository.CreateAsync(user);
            return createdUser;
        }

        public User? GetUserByEmail(string email)
        {
            return repository.GetAll().SingleOrDefault(x => x.Email == email);
        }
    }
}
