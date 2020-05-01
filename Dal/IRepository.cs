using System.Collections.Generic;
using System.Linq;

namespace Dal
{
    public interface IRepository<T>
    {
        // Add
        void Add(T item);

        // Edit
        void Edit(T item);

        // Delete
        void Delete(T item);

        // Find
        IQueryable<T> Find();
    }
}