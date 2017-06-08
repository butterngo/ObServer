namespace ConsoleApp1.Mongo
{
    using MongoDB.Driver;

    public interface IMongoContext
    {
        IMongoDatabase Database { get; }

        IMongoCollection<T> GetCollection<T>();

        IMongoCollection<T> GetCollection<T>(string name, IndexKeysDefinition<T> keys, CreateIndexOptions options);
    }
}
