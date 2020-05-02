using System.Collections.Generic;
using System.Linq;

namespace Dal
{
    public interface IRepository<T>
    {
        // Add
        void Add(T item);

        // Edit
        void Update();

        // Delete
        void Delete(T item);

        // Find
        IQueryable<T> Find();
    }
}