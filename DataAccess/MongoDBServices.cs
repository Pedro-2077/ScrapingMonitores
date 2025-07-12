using DataAccess.Models;
using MongoDB.Driver;

namespace DataAccess
{
    public class MongoDBServices
    {
        private readonly IMongoCollection<ProductObject> _productsCollection;

        public MongoDBServices(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _productsCollection = database.GetCollection<ProductObject>(collectionName);
        }

        public async Task InsertProductsAsync(List<ProductObject> products)
        {
            if (products != null && products.Count > 0)
            {
                await _productsCollection.InsertManyAsync(products);
            }
        }
    }
}