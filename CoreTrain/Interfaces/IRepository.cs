namespace CoreTrain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public T GetEntity ( int Id );
        public List<T> GetAll ();
        public void Create ( T entity );
        public void Update ( T entity );
        public void Delete ( T entity );
    }
}
