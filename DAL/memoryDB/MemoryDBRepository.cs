using System.Collections.Generic;
using blog.DAL;
using blog.models;

namespace blog.memoryDB
{
    public class MemoryDBRepository<T> : IRepository<T>
    {
        public void Add(T item)
        {
            string typeName = item.GetType().Name;
            switch (typeName)
            {
                case "NormalUsers":
                    NormalUser usr = item as NormalUser;
                    MemoryDB.NormalUsers.Add(usr);
                    break;
                case "LoginSessions":
                    LoginSession loginSession = item as LoginSession;
                    MemoryDB.LoginSessions.Add(loginSession);
                    break;
                default:
                    break;
            }
        }

        public void Edit(T item)
        {
            string typeName = item.GetType().Name;
            switch (typeName)
            {
                case "NormalUsers":
                    NormalUser usr = item as NormalUser;
                    NormalUser exisitingUser = MemoryDB.NormalUsers.Find(u => u.Email == usr.Email);
                    MemoryDB.NormalUsers.Remove(exisitingUser);
                    MemoryDB.NormalUsers.Add(usr);
                    break;
                case "LoginSessions":
                    LoginSession session = item as LoginSession;
                    LoginSession existingSession = MemoryDB.LoginSessions.Find(u => u.Token == session.Token);
                    MemoryDB.LoginSessions.Remove(existingSession);
                    MemoryDB.LoginSessions.Add(session);
                    break;
                default:
                    break;
            }
        }

        public void Delete(T item)
        {
            string typeName = item.GetType().Name;
            switch (typeName)
            {
                case "NormalUsers":
                    NormalUser usr = item as NormalUser;
                    MemoryDB.NormalUsers.Remove(usr);
                    break;
                case "LoginSessions":
                    LoginSession loginSession = item as LoginSession;
                    MemoryDB.LoginSessions.Remove(loginSession);
                    break;
                default:
                    break;
            }
        }

        public List<T> Find(T item)
        {
            string typeName = item.GetType().Name;
            switch (typeName)
            {
                case "NormalUsers":
                    NormalUser usr = item as NormalUser;
                    MemoryDB.NormalUsers.FindAll(u => usr.Email!="" ? u.Email == usr.Email);
                    break;
                case "LoginSessions":
                    LoginSession loginSession = item as LoginSession;
                    MemoryDB.LoginSessions.Add(loginSession);
                    break;
                default:
                    break;
            }
        }

        public T FindOne(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}