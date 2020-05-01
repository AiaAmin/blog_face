using System.Collections.Generic;
using Dal.models;

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
            NormalUser fakeUser = new NormalUser() {Email = "aia@mail.com", Password = "ahmed", Gender = "Female"};
            List<NormalUser> users = new List<NormalUser>() {fakeUser};
            List<T> usrs = users as List<T>;
            return usrs;
        }

        public T FindOne(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}