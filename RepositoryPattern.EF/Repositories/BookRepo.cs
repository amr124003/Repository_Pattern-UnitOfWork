using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Interfaces;
using RepositoryPattern.Core.Models;
using RepositoryPattern.EF.Context;

namespace RepositoryPattern.EF.Repositories
{
    public class BookRepo : Repository<Book>, IBook
    {
        private readonly ApplicationDbcontext context;

        public BookRepo ( ApplicationDbcontext context ) : base(context)
        {
            this.context = context;
        }
        public async Task<List<Book>> GetPaginatedBooks ()
        {
            return await context.Books.ToListAsync();
        }
    }
}
