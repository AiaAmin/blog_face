using System.Collections.Generic;
using System.Reflection.Metadata;
using Dal.models;
using Dal.pgDB;

namespace Dal.DAL.pgDB
{
    public class PgRepository<T> : IRepository<T>
    {
        public void Add(T item)
        {
            MorafikContext ctx = new MorafikContext();
            ctx.SaveChanges();
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