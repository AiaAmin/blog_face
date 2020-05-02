using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Dal.pgDB
{
    public class PgRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly MorafikContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public PgRepository()
        {
            _dbContext = new MorafikContext();
            _dbContext.Database.EnsureCreated();
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
            _dbContext.SaveChanges();
        }

        public void Update()
        {
            _dbContext.SaveChanges();
        }

        public void Delete(T item)
        {
            _dbSet.Remove(item);
            _dbContext.SaveChanges();
        }

        public IQueryable<T> Find()
        {
            return _dbSet.AsQueryable();
        }
    }
}