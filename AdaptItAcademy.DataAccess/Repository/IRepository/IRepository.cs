using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptItAcademy.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T:class
    {
        T Get(int id);

        IEnumerable<T> GetAll(string includeProperties = null);

        void Add(T entity);

        void Remove(int id);

        void Remove(T entity);
    }
}
