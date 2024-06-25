using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)] //Benzersiz olduğunu belirtmek için ObjectId seçtik.
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
