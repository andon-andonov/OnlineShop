using System.Linq.Expressions;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Application.Common.Interfaces;

public interface ISpecification<TEntity> where TEntity : EntityBase
{
    Expression<Func<TEntity, bool>> Filter { get; }
    Expression<Func<TEntity, object>> SortBy{ get; }
}
