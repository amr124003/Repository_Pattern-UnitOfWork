using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Interfaces;
using RepositoryPattern.EF.Context;

namespace RepositoryPattern.EF.Repositories
{
    public class Repository<T> : IRepostitoy<T> where T : class
    {
        private readonly ApplicationDbcontext context;
        public DbSet<T> Entity;

        public Repository ( ApplicationDbcontext context )
        {
            this.context = context;
            Entity = context.Set<T>();

        }
        public async Task Create ( T entity )
        {
            await Entity.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete ( T entity )
        {
            Entity.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAll ()
        {
            Entity.ToList().Clear();
            await context.SaveChangesAsync();
        }

        public async Task<T> Get ( int Id )
        {
            return await Entity.FindAsync(Id);
        }

        public async Task<List<T>> GetAll ()
        {
            return await Entity.ToListAsync() ?? new List<T>();
        }

        public async Task Update ( T entity )
        {
            Entity.Update(entity);
            await context.SaveChangesAsync();
        }


    }
}
