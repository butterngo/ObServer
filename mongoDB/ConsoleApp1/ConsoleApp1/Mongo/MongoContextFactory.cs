namespace ConsoleApp1.Mongo
{
    using ConsoleApp1.Domain;
    using MongoDB.Driver;
    using System;
    using System.Threading.Tasks;

    public class MongoDbContextFactory : IMongoContextFactory
    {
        private readonly string _connectionString;

        private const int ExpireDay = 7;

        public MongoDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task CreateDatabaseAsync(IMongoContext mongoContext)
        {
            await CreateCollectionProductAsync(mongoContext);

            await CreateCollectionCategoryAsync(mongoContext);

        }

        public IMongoContext GetMongoContext()
        {
            return GetMongoContext(_connectionString);
        }

        public IMongoContext GetMongoContext(string connectionString)
        {
            var mongoUrlBuilder = new MongoUrlBuilder(connectionString);

            var mongoClient = new MongoClient(connectionString);

            return new MongoContext(mongoClient, mongoUrlBuilder.DatabaseName);
        }

        #region private method

        private async Task CreateCollectionProductAsync(IMongoContext mongoContext)
        {
            var notification = mongoContext.GetCollection<Product>();

            var options = new CreateIndexOptions { ExpireAfter = TimeSpan.FromDays(ExpireDay) };

            await notification.Indexes.CreateOneAsync(Builders<Product>.IndexKeys.Descending(x => x.CreatedAt), options);
        }

        private async Task CreateCollectionCategoryAsync(IMongoContext mongoContext)
        {
            var clientUser = mongoContext.GetCollection<Category>();

            await clientUser.Indexes.CreateOneAsync(Builders<Category>.IndexKeys.Ascending(x => x.CreatedAt));
        }

        #endregion
    }
}
