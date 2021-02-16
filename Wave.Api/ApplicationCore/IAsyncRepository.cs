using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Wave.Api.ApplicationCore
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id, CancellationToken cancellationToken);

        Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken);

        Task<IReadOnlyList<T>> ListAllAsync(int perPage, int page, CancellationToken cancellationToken);

        //Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);

        Task<T> AddAsync(T entity, CancellationToken cancellationToken);

        TaskItem UpdateAsync(T entity, CancellationToken cancellationToken);

        TaskItem DeleteAsync(T entity, CancellationToken cancellationToken);

        //Task<int> CountAsync(ISpecification<T> spec);
    }
}
