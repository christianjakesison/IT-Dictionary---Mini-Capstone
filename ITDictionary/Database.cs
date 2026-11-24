using MongoDB.Driver;

namespace ITDictionary
{
    public static class Database
    {
        private static readonly IMongoDatabase db =
            new MongoClient("mongodb://localhost:27017").GetDatabase("ITDictionary");

        public static IMongoCollection<Term> Terms => db.GetCollection<Term>("terms");

        public static IMongoCollection<Admin> Admins => db.GetCollection<Admin>("admins");
    }
}