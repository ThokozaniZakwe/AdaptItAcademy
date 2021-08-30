using AdaptItAcademy.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaptItAcademy.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace AdaptItAcademy.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AcademyDbContext academyDb;
        internal DbSet<T> dbSet;

        public Repository(AcademyDbContext db)
        {
            academyDb = db;
            this.dbSet = academyDb.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if(includeProperties != null)
            {
                foreach(var includeProp in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        public void Remove(int id)
        {
            T entity = dbSet.Find(id);
            Remove(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
    }
}
