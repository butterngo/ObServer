namespace ConsoleApp1.Mongo
{
    using System.Threading.Tasks;

    public interface IMongoContextFactory
    {
        IMongoContext GetMongoContext();

        IMongoContext GetMongoContext(string connectionString);

        Task CreateDatabaseAsync(IMongoContext mongoContext);
    }
}
