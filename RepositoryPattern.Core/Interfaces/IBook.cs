using RepositoryPattern.Core.Models;

namespace RepositoryPattern.Core.Interfaces
{
    public interface IBook : IRepostitoy<Book>
    {
        public Task<List<Book>> GetPaginatedBooks ();
    }
}
