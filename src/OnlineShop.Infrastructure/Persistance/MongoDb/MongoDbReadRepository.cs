using MongoDB.Driver;
using OnlineShop.Application.Common.Interfaces;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Infrastructure.Persistance.MongoDb;

public class MongoDbReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : EntityBase
{
    protected readonly IMongoCollection<TEntity> collection;

    public MongoDbReadRepository(MongoDbContext context)
    {
        this.collection = context.Database.GetCollection<TEntity>(typeof(TEntity).Name);
    }

    public async Task<TEntity> Get(Guid id)
    {
        return await this.collection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<TEntity>> Get()
    {
        return await this.collection.Find(_ => true).ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> Get(ISpecification<TEntity> specification)
    {
        return await this.collection.Find(specification.Filter).SortBy(specification.SortBy).ToListAsync();
    }

    public async Task<long> Count()
    {
        return await this.collection.CountDocumentsAsync(x => true);
    }
}
