
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VoteLogger.Model;

public class CandidateModel
{
	[BsonId]
	[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

	public string? Id { get; set; }
	public string StateOfRepresentation { get; set; } = "State of Rep - Placeholder";
	public string FullName { get; set; } = "FullName - Placeholder";
	public string PoliticalParty { get; set; } = "Political Party - Placeholder";
}


