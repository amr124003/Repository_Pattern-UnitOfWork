using RepositoryPattern.Core.Interfaces;
using RepositoryPattern.Core.Models;
using RepositoryPattern.EF.Context;

namespace RepositoryPattern.EF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbcontext context;
        public UnitOfWork ( ApplicationDbcontext _context )
        {
            context = _context;
            AuthorRepo = new Repository<Author>(context);
            BookRepo = new BookRepo(context);
        }

        public IRepostitoy<Author> AuthorRepo { get; private set; }
        public IBook BookRepo { get; private set; }
        public int Commit ()
        {
            return context.SaveChanges();
        }
        public void Dispose ()
        {
            context.Dispose();
        }
    }
}
