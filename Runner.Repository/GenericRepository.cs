using Runner.Data;
using Runner.Repository.Interfaces;

namespace Runner.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> 
        where T : class
    {
        private readonly RunnerDbContext _context;

        public GenericRepository(RunnerDbContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Add(IList<T> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Update(IList<T> items)
        {
            _context.UpdateRange(items);
            _context.SaveChanges();
        }

        public void RemoveRange(IList<T> items)
        {
            _context.RemoveRange(items);
            _context.SaveChanges();
        }

        public IList<T> Get(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
