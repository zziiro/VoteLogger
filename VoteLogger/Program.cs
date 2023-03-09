
using VoteLogger.Model;
using VoteLogger.databaseAccess;

namespace VoteLogger;

class Program {
    public static void Main(string[] args) {
        VoterInformation();
        //SeeAllVoters();
        //AddNewCandidates();
        //SeeAllCandidates();
    }

    public static void VoterInformation()
    {
        string? fullName;
        string? age;
        string? state;
        string? vote;

        DataAccess data = new();

        Console.WriteLine("Full Name: ");
        fullName = Console.ReadLine();

        Console.WriteLine("Age: ");
        age = Console.ReadLine();

        Console.WriteLine("State: ");
        state = Console.ReadLine();

        Console.WriteLine("Vote: ");
        data.SeeAllCandidates();
        vote = Console.ReadLine();

        VoterModel voterInformation = new();

        // set input equal to the voter model
        voterInformation.FullName = fullName;
        voterInformation.Age = age;
        voterInformation.State = state;
        voterInformation.Vote = vote;


        // create dataAccess object
        DataAccess dbAccess = new();

        // add the voter to Mongo
        dbAccess.AddToMongo(voterInformation);
         
    }

    public static void SeeAllVotes()
    {
        DataAccess dbAccess = new();
        dbAccess.SeeAllNames();
    }


    /* CANDIDATES SECTION */
    public static void AddNewCandidates()
    {
        string? fullName;
        string? stateofRepresentation;
        string? politicalParty;

        Console.WriteLine("Name of Candidate: ");
        fullName = Console.ReadLine();

        Console.WriteLine("State of Representation: ");
        stateofRepresentation = Console.ReadLine();

        Console.WriteLine("Political Party: ");
        politicalParty = Console.ReadLine();

        DataAccess dataAccess = new();
        CandidateModel candidateModel = new();

        candidateModel.FullName = fullName;
        candidateModel.StateOfRepresentation = stateofRepresentation;
        candidateModel.PoliticalParty = politicalParty;

        dataAccess.AddCandidates(candidateModel);
    }

    public static void SeeAllCandidates()
    {
        DataAccess dataAccess = new();

        dataAccess.SeeAllCandidates();
    }
    

}


