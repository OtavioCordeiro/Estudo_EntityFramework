using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_EntityFrameworkCore.Data.Interface
{
    public interface IRepository<T> where T : class
    {
        int Count(Func<T, bool> predicate);

        void Create(T entity);

        void delete(T entity);

        IEnumerable<T> Find(Func<T, bool> predicate);

        IEnumerable<T> GetAll();

        T GetById(int id);

        void Update(T entity);
    }
}
