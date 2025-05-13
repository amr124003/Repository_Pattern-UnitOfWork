using RepositoryPattern.Core.Models;

namespace RepositoryPattern.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IRepostitoy<Author> AuthorRepo { get; }
        public IBook BookRepo { get; }
        public int Commit ();
    }
}
