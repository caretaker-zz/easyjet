using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Interview.Implementation
{
    public class CustomerRepository<T,I> : Interview.IRepository<T, I> where T:Custommer<I>
    {
        private Dictionary<I, T> _backingStore = new Dictionary<I, T>();
        public void Delete(I id)
        {
            _backingStore.Remove(id);
        }

        public T Get(I id)
        {
            return _backingStore.Where(r => r.Key.Equals(id)).FirstOrDefault().Value;
        }

        public IEnumerable<T> GetAll()
        {
            return _backingStore.Select(r=>r.Value).ToList(); ;
        }

        public void Save(T item)
        {
            _backingStore.Add(item.Id, item);
        }
    }
}
