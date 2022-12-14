using OnlineShop.Domain.Entities;

namespace OnlineShop.Application.Common.Interfaces;

public interface IReadRepository<TEntity> where TEntity : EntityBase
{
    Task<TEntity> Get(Guid id);
    Task<IEnumerable<TEntity>> Get();
    Task<IEnumerable<TEntity>> Get(ISpecification<TEntity> specification);
    Task<long> Count();
}
