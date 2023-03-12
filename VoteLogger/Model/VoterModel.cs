using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VoteLogger.Model;

public class VoterModel
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

    public string? Id { get; set; }
    public string FullName { get; set; } = "FullName -  test placeholder";
    public string Age { get; set; } = "Age - test placeholder";
    public string State { get; set; } = "State - test placeholder";
    public string Vote { get; set; } = "Vote - test placeholder";

}

