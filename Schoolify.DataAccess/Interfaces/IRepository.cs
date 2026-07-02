using Schoolify.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<Result<T>> AddAsync(T entity);
        Task<Result<T>> AddAndSaveAsync(T entity);
        Task<Result<bool>> AddRangeAsync(IEnumerable<T> entities);
        Task<Result<bool>> AddRangeAndSaveAsync(IEnumerable<T> entities);

        Task<Result<T>> UpdateAsync(T entity);
        Task<Result<T>> UpdateAndSaveAsync(T entity);

        Task<Result<bool>> DeleteAsync(int id);
        Task<Result<bool>> DeleteAndSaveAsync(int id);
        Task<Result<bool>> DeleteAsync(T entity);
        Task<Result<bool>> DeleteAndSaveAsync(T entity);
        Task<Result<bool>> DeleteRangeAsync(IEnumerable<T> entities);
        Task<Result<bool>> DeleteRangeAndSaveAsync(IEnumerable<T> entities);

        Task<Result<IEnumerable<T>>> GetAllAsync(
Expression<Func<T, bool>> predicate = null,
Func<IQueryable<T>, IQueryable<T>>? include = null, bool? isTracking = false);

        Task<Result<T>> FindByAsync(
Expression<Func<T, bool>> predicate,
Func<IQueryable<T>, IQueryable<T>>? include = null);

        Task<Result<PagedResult<T>>> GetPagedAsync(
Expression<Func<T, bool>>? filter = null,
Func<IQueryable<T>, IQueryable<T>>? include = null,
Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
int pageNumber = 1,
int pageSize = 10);


        Task<Result<bool>> SaveChangesAsync();

    }
}
