
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
        DataAccess data = new();

        Console.WriteLine("Full Name: ");
        string? fullName = Console.ReadLine();

        Console.WriteLine("Age: ");
        string? age = Console.ReadLine();

        Console.WriteLine("State: ");
        string? state = Console.ReadLine();

        Console.WriteLine("Vote: ");
        data.SeeAllCandidates();
        string? vote = Console.ReadLine();

        VoterModel voterInformation = new()
        {
            FullName = fullName,
            Age = age,
            State = state,
            Vote = vote,
        };
        
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
        CandidateModel candidateModel = new() {
            FullName = fullName,
            StateOfRepresentation = stateofRepresentation,
            PoliticalParty = politicalParty,
        };

        dataAccess.AddCandidates(candidateModel);
    }

    public static void SeeAllCandidates()
    {
        DataAccess dataAccess = new();

        dataAccess.SeeAllCandidates();
    }
    

}


