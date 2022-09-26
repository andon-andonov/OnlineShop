using System;
using MongoDB.Driver;

namespace OnlineShop.Infrastructure.Persistance.MongoDb;

public class MongoDbContext
{
    public IMongoDatabase Database { get; init; }

    public MongoDbContext(MongoDbOptions options)
    {
        IMongoClient mongoClient = new MongoClient(options.ConnectionString);
        this.Database = mongoClient.GetDatabase(options.DatabaseName);
    }
}

