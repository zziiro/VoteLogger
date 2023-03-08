
using VoteLogger.Model;
using VoteLogger.databaseAccess;

namespace VoteLogger;

class Program {
    public static void Main(string[] args) {
        VoterInformation();
    }

    public static void VoterInformation()
    {
        // create new model object

        string? fullName;
        string? age;
        string? state;
        string? vote;

        Console.WriteLine("Full Name: ");
        fullName = Console.ReadLine();

        Console.WriteLine("Age: ");
        age = Console.ReadLine();

        Console.WriteLine("State: ");
        state = Console.ReadLine();

        Console.WriteLine("Vote: ");
        vote = Console.ReadLine();

        VoterModel voterInformation = new VoterModel();

        // set input equal to the voter model
        voterInformation.FullName = fullName;
        voterInformation.Age = age;
        voterInformation.State = state;
        voterInformation.Vote = vote;


        // create dataAccess object
        dataAccess dbAccess = new dataAccess();

        // add the voter to Mongo
        dbAccess.AddToMongo(voterInformation);
         
    }

}


