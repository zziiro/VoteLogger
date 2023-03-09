
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VoteLogger.Model;

public class CandidateModel
{
	[BsonId]
	[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

	public string? id;
	public string? StateOfRepresentation;
	public string? FullName;
	public string? PoliticalParty;
}


