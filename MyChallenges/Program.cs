using MyChallenges.ChallengesDirectory.BinaryArraySearch;
using MyChallenges.ChallengesDirectory.PalindromicNumber;

class Program
{
   
   
    public static void Main(string[] args)
    {
        PalindromicNumberServices palindromicNumber = new PalindromicNumberServices();

        var result = palindromicNumber.ConvertPalindromicString();
        
        Console.WriteLine(string.Join(", ", result));
    }
}