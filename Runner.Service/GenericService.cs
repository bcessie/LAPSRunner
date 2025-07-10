using Runner.Models.Interfaces;
using Runner.Repository.Interfaces;
using Runner.Service.Interfaces;
using System;

namespace Runner.Service
{
    public class GenericService<T> : IGenericService<T>
        where T : IModel
    {
        IGenericRepository<T> _repo;

        public GenericService(IGenericRepository<T> repo)
        {
            _repo = repo;
        }

        public IList<T> Get(Func<T, bool> predicate)
        {
            return _repo.Get(predicate);
        }

        public IList<T> GetAll()
        {
            return _repo.GetAll();
        }

        public void RemoveRange(IList<T> items)
        {
            _repo.RemoveRange(items);
        }

        public string Add(T item)
        {
            string errors = string.Empty;

            if (!ItemExistWithPath(item))
            {
                _repo.Add(item);
            }
            else
            {
                errors = "The item with the specified path already exists";
            }

            return errors;
        }

        public string Add(IList<T> items)
        {
            string errors = string.Empty;

            var itemsToUse = items.Where(x => !ItemExistWithPath(x)).ToList();

            if (items.Count != itemsToUse.Count)
            {
                errors = "Some items specified already exists with the path";
            }

            _repo.Add(itemsToUse);

            return errors;
        }

        private bool ItemExistWithPath(T item)
        {
            return Get(x => x.Description == item.Description && x.Id != item.Id).Any();
        }

        public void Update(T item)
        {
            _repo.Update(item);
        }

        public void Update(IList<T> items)
        {
            _repo.Update(items);
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                     