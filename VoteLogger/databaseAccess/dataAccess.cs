
using VoteLogger.Model;
using MongoDB.Driver;

namespace VoteLogger.databaseAccess;


public class dataAccess
{

	string connectionString = "mongodb+srv://cb:cebiros@voterinformation.5tdqgqr.mongodb.net/?retryWrites=true&w=majority";
	string databaseName = "VoterInformation";
	string dbCollection = "Voters";

	public IMongoCollection<T> MongoSetUp<T>(in string collection)
	{
		var client = new MongoClient(connectionString);
		var db = client.GetDatabase(databaseName);
		return db.GetCollection<T>(collection);
	}

	// add voter information and vote to mongo
	public void AddToMongo(VoterModel voter)
	{
		var voterCollection = MongoSetUp<VoterModel>(dbCollection);
		voterCollection.InsertOne(voter);
	}
	
}


