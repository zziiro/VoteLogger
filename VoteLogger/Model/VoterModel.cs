using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VoteLogger.Model;

public class VoterModel
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

    public string? ID { get; set; }
    public string? FullName { get; set; }
    public string? Age { get; set; }
    public string? State { get; set; }
    public string? Vote { get; set; }

}

