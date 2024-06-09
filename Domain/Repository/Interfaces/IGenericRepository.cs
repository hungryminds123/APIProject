using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.Interfaces
{
    public interface IGenericRepository<T> where  T:class
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();  // Read

        Task<T> Add(T entity);   // create (C)

        Task<T> Update(T entity);     // update (U)

        Task<T> Delete(int id);   // delete (D)

        Task<T> Find(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> predicate);
    }
}
