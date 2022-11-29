using Microsoft.EntityFrameworkCore.ChangeTracking;
using PortaalBackend.Domain.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace PortaalBackend.Business.Infrastructure
{
    [ExcludeFromCodeCoverage]
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DataContext dataContext;

        public Repository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            EntityEntry<T> entityEntry = await dataContext.AddAsync(entity);
            return entityEntry.Entity;
        }

        public IQueryable<T> GetAll()
        {
            return dataContext.Set<T>();
        }

        public T? GetById(int id)
        {
            return dataContext.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await dataContext.SaveChangesAsync();
        }

        public T Update(T entity)
        {
            EntityEntry<T> entityEntry = dataContext.Update(entity);
            return entityEntry.Entity;
        }
    }
}
