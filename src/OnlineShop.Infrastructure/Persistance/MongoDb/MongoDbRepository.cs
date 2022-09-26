using MongoDB.Driver;
using OnlineShop.Application.Common.Interfaces;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Infrastructure.Persistance.MongoDb;

public class MongoDbRepository<TEntity> : MongoDbReadRepository<TEntity>, IRepository<TEntity> where TEntity : EntityBase
{
    public MongoDbRepository(MongoDbContext context) : base(context)
    {
    }

    public async Task<TEntity> Add(TEntity entity)
    {
        entity.Id = Guid.NewGuid();
        await this.collection.InsertOneAsync(entity);
        return await this.Get(entity.Id);
    }

    public async Task Update(TEntity entity)
    {
        await this.collection.ReplaceOneAsync(x => x.Id == entity.Id, entity);
    }

    public async Task Delete(TEntity entity)
    {
        await this.collection.DeleteOneAsync(x => x.Id == entity.Id);
    }
}
