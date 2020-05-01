using System.Collections.Generic;
using Dal.models;

namespace Dal.DAL.pgDB
{
    public class PgRepository<T> : IRepository<T>
    {
        public void Add(T item)
        {
            BlogContext ctx = new BlogContext();
            ctx.Users.Add(new User()
            {
                Email = "ayman@mail.com",
                Name = "ayman",
                Password = "myPass"
            });

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