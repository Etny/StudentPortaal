using System.Linq.Expressions;

namespace PortaalBackend.Domain.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        public IQueryable<T> GetAll();
        public T? GetById(int id, params Expression<Func<T, object>>[] includes);
        public T Update(T entity);
        public Task<T> CreateAsync(T entity);
        public Task SaveChangesAsync();
        public void DeleteById(int id);
    }
}
