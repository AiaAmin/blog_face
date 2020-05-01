using System.Collections.Generic;

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
        List<T> Find(T item);
        T FindOne(T item);
    }
}