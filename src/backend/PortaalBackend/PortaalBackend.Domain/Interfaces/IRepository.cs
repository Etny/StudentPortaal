namespace PortaalBackend.Domain.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        public IQueryable<T> GetAll();
        public T? GetById(int id);
        public T Update(T entity);
        public Task<T> CreateAsync(T entity);
        public Task SaveChangesAsync();
    }
}
