
using VoteLogger.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace VoteLogger.databaseAccess;


public class DataAccess
{

	const string connectionString = "mongodb+srv://cb:cebiros@voterinformation.5tdqgqr.mongodb.net/?retryWrites=true&w=majority";
	const string databaseName = "VoterInformation";
	const string candidateCollection = "Candidates";
	const string votersCollection = "Voters";

	public IMongoCollection<T> MongoSetUp<T>(in string collection)
	{
		var client = new MongoClient(connectionString);
		var db = client.GetDatabase(databaseName);
		return db.GetCollection<T>(collection);
	}

	// add voter information and vote to mongo
	public void AddToMongo(VoterModel voter)
	{
		var voterCollection = MongoSetUp<VoterModel>(votersCollection);
		voterCollection.InsertOne(voter);
	}

	public void SeeAllNames()
	{
		var voterCollection = MongoSetUp<VoterModel>(votersCollection);

		var voters = voterCollection.Find(new BsonDocument()).ToList();
		foreach (VoterModel voter in voters)
		{
			Console.WriteLine("Name: {0} -> Vote: {1}", voter.FullName, voter.Vote);
		}
	}

	public void SeeAllCandidates()
	{
		var candidatesCollection = MongoSetUp<CandidateModel>(candidateCollection);
		var candidates = candidatesCollection.Find(new BsonDocument()).ToList();
		foreach(CandidateModel candidatemodel in candidates)
		{
			Console.WriteLine("{0} | {1}", candidatemodel.FullName, candidatemodel.StateOfRepresentation);
		}
	}

	public void AddCandidates(CandidateModel candidatemodel)
	{
		var candidatesCollection = MongoSetUp<CandidateModel>(candidateCollection);
		candidatesCollection.InsertOne(candidatemodel);
	}
}


