using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Interfaces;
using RepositoryPattern.EF.Context;

namespace RepositoryPattern.EF.Repositories
{
    public class Repository<T> : IRepostitoy<T> where T : class
    {
        private readonly ApplicationDbcontext context;

        public Repository ( ApplicationDbcontext context )
        {
            this.context = context;
        }
        public async Task Create ( T entity )
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete ( T entity )
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAll ()
        {
            context.Set<T>().ToList().Clear();
            await context.SaveChangesAsync();
        }

        public async Task<T> Get ( int Id )
        {
            return await context.Set<T>().FindAsync(Id);
        }

        public async Task<List<T>> GetAll ()
        {
            return await context.Set<T>().ToListAsync() ?? new List<T>();
        }

        public async Task Update ( T entity )
        {
            context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
        }


    }
}
