using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ITDictionary
{
    public class Term
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Word { get; set; } = "";
        public string Category { get; set; } = "";
        public string Definition { get; set; } = "";
        public string Example { get; set; } = "";
    }
}