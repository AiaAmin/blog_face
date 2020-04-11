using System.Collections.Generic;
using blog.models;

namespace blog.DAL
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
    }
}