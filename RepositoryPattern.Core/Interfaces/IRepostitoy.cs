namespace RepositoryPattern.Core.Interfaces
{
    public interface IRepostitoy<T> where T : class
    {
        public Task<T> Get ( int Id );
        public Task<List<T>> GetAll ();
        public Task Create ( T entity );
        public Task Update ( T entity );
        public Task Delete ( T entity );
        public Task DeleteAll ();
    }
}
