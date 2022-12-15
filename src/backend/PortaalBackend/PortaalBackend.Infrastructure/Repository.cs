using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using PortaalBackend.Domain.Interfaces;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace PortaalBackend.Infrastructure
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

        public T? GetById(int id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> set = dataContext.Set<T>();

            foreach(var include in includes)
                set = set.Include(include);

            return set.SingleOrDefault(e => e.Id == id);
        }

        public void DeleteById(int id)
        {
            dataContext.Remove(id);
        }

        public T Update(T entity)
        {
            EntityEntry<T> entityEntry = dataContext.Update(entity);
            return entityEntry.Entity;
        }

        public async Task SaveChangesAsync()
        {
            await dataContext.SaveChangesAsync();
        }
    }
}
