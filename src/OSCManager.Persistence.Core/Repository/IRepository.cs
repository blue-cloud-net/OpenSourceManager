using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using OSCManager.Abstractions.Condition;
using OSCManager.Persistence.Core.Entities;

namespace OSCManager.Persistence.Core.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task SaveAsync(T entity, CancellationToken cancellationToken = default);
        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        Task AddManyAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
        Task<int> DeleteManyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> FindManyAsync(Expression<Func<T, bool>> expression, OrderBy<T> orderBy = default, Paging paging = default, CancellationToken cancellationToken = default);
        Task<int> CountAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
        Task<T?> FindAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
    }
}
