using Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly SampleDatabaseDbContext dbContext;

        public GenericRepository(SampleDatabaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Find(Expression<Func<T, bool>> predicate)
        {
           return  await dbContext.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> predicate)
        {
            return await dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
