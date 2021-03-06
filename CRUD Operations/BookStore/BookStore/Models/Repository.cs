using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface Repository<T> where T : class
   {
        T Add(T item);
    T Update(T item);

    T Delete(T item);
    Task<IReadOnlyCollection<T>> GetAsync(Expression< Func<T,bool> > condition = null);
    Task<T> GetByIdAsync(int id);
    Task<int> SaveAsync();
  }
}

