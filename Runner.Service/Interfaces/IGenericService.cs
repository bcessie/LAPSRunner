namespace Runner.Service.Interfaces
{
    public interface IGenericService<T>
    {
        public string Add(T item);

        public IList<T> GetAll();

        public string Add(IList<T> items);

        public void Update(T item);

        public void Update(IList<T> items);

        public void RemoveRange(IList<T> items);

        public IList<T> Get(Func<T, bool> predicate);
    }
}
