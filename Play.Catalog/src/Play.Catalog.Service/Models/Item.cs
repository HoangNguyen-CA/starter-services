using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Play.Common;

namespace Play.Catalog.Service.Models;


public class Item : IEntity

{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public DateTimeOffset CreatedDate { get; set; }

}