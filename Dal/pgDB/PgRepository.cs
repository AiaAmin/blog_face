using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using Dal.models;
using Dal.pgDB;
using Microsoft.EntityFrameworkCore;

namespace Dal.DAL.pgDB
{
    public class PgRepository<T> : IRepository<T>
    {
        public void Add(T item)
        {
            return;
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
            throw new System.NotImplementedException();
        }

        public T FindOne(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}