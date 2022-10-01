using System;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Application.Common.Interfaces;

public interface IRepository<TEntity> : IReadRepository<TEntity> where TEntity : EntityBase
{
    Task<TEntity> Add(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(TEntity entity);
}

