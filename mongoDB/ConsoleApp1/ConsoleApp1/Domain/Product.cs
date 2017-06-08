namespace ConsoleApp1.Domain
{
    using MongoDB.Bson;
    using System;
    public class Product
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public ObjectId CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
