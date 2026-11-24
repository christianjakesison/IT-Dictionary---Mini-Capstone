using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ITDictionary
{
    public class Admin
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Username { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Salt { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}