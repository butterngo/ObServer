namespace ConsoleApp1
{
    using ConsoleApp1.Domain;
    using ConsoleApp1.Mongo;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            IMongoContextFactory context = new MongoDbContextFactory(@"mongodb://localhost:1234,localhost:4321,localhost:12345/DemoMongo?replicaSet=rp1");
            var category = context.GetMongoContext().GetCollection<Category>();

            for (int i = 0; i < 10; i++)
            {
                category.InsertOne(new Category
                {
                    Name = "Categor" + i.ToString(),
                    CreatedAt = DateTime.UtcNow
                });
            }
        }
    }
}
