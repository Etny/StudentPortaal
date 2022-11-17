using PortaalBackend.Domain.Interfaces;

namespace PortaalBackend.Business.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
    }
}
