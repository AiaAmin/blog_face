using System.Collections.Generic;

namespace Dal.DAL
{
    public class FakeRepo<T> : IRepository<T>
    {
        public void Add(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new System.NotImplementedException();
        }

        public List<T> Find(T item)
        {
            return null;
        }

        public T FindOne(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}