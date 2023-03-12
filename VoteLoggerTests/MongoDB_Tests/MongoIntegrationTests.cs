
using Xunit;
using FluentAssertions;
using MongoDB.Driver;
using VoteLogger;
using VoteLogger.databaseAccess;
using VoteLogger.Model;
using MongoDB.Driver.Core.Configuration;

namespace VoteLoggerTests.MongoDB_Tests;

public class MongoTests
{
	private readonly DataAccess _dataAccess;
	private VoterModel _voterModel;
	private readonly CandidateModel _candidateModel;
	

    public MongoTests()
	{
		DataAccess _dataAccess = new();
		VoterModel _voterModel = new(){
			FullName = "Colin Biros",
			Age = "22",
			State = "Ohio",
			Vote = "Joe Biden"
		};
		CandidateModel _candidateModel = new()
		{
			FullName = "Joe Biden",
			StateOfRepresentation = "New York",
			PoliticalParty = "Democrat",

		};
    }


	[Fact]
	public void DataAccess_AddUserToMongo_AddsNewUser()
	{
		if(_voterModel != null)
		{
            _dataAccess.AddToMongo(_voterModel);
        }
		
	}

	[Fact]
	public void DataAccess_SeeAllNames_ReturnsAllVoterNames()
	{
		if(_voterModel != null)
		{
			_dataAccess.SeeAllNames();
		}
	}

	[Fact]
	public void DataAccess_AddCandidates_CreatesNewCandidate()
	{
		if(_candidateModel != null) {
            _dataAccess.AddCandidates(_candidateModel);
        }
    }
}


