using Runner.Models.Interfaces;
using Runner.Repository.Interfaces;
using Runner.Service.Interfaces;
using System;
using System.IO;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var itemsToUse = ValidationFilter([item], out errors);

            if (itemsToUse.Any())
            {
                _repo.Add(itemsToUse.First());
            }
            else
            {
                errors = "The item with the specified path already exists";
            }

            return errors;
        }

        public string Add(IList<T> items)
        {
            var errors = string.Empty;
            var itemsToUse = ValidationFilter(items, out errors);

            _repo.Add(itemsToUse);

            return errors.ToString();
        }

        private IList<T> ValidationFilter(IList<T> items, out string errors)
        {
            var errorBuilder = new StringBuilder();

            var itemsToUse = items.Where(x => !ItemExistWithId(x)).ToList();

            if (items.Count != itemsToUse.Count)
            {
                if (items.Count > 1)
                {
                    errorBuilder.AppendLine("Some items already exist and won't be added again.");
                }
                else
                {
                    errorBuilder.AppendLine("The item already exists.");
                }
                
            }

            itemsToUse = itemsToUse.Where(x => !ItemExistWithPath(x)).ToList();

            if (items.Count != itemsToUse.Count)
            {
                if (items.Count > 1)
                {
                    errorBuilder.AppendLine("Some items specified already exists with the path.");
                }
                else
                {
                    errorBuilder.AppendLine("The item with the specified path already exists.");
                }
            }

            errors = errorBuilder.ToString();

            return itemsToUse;
        }

        private bool ItemExistWithPath(T item) => Get(x => x.Description == item.Description && x.Id != item.Id).Any();

        private bool ItemExistWithId(T item) => Get(x => x.Id == item.Id).Any();

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