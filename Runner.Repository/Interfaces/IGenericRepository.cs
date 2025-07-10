using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Repository.Interfaces
{
    public interface IGenericRepository<T>
    {
        public void Add(T item);

        public IList<T> GetAll();

        public void Add(IList<T> items);

        public void Update(T item);

        public void Update(IList<T> items);

        public void RemoveRange(IList<T> items);

        public IList<T> Get(Func<T, bool> predicate);
    }
}
