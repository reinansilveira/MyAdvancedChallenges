using MyChallenges.ChallengesDirectory.BinaryArraySearch;

class Program
{
   
   
    public static void Main(string[] args)
    {
        SeachBinary searchBinary = new SeachBinary();

        var result = searchBinary.Ordenation();
        
        Console.WriteLine(string.Join(", ", result));
    }
}