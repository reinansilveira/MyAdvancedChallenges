namespace MyChallenges.ChallengesDirectory.PalindromicNumber;

public class PalindromicNumberServices
{
    public int input = 121;
    public int input2 = 748473;
    
    public string ConvertPalindromicString()
    {
       var inputString =  input.ToString();
       var inputString2 = input2.ToString();

      var inputStringReverse = new string(inputString.Reverse().ToArray());
      var inputStringReverse2 = new string(inputString2.Reverse().ToArray());

      if (inputString == inputStringReverse)
      {
          return  "é um palíndromo";
      }
      return "não é um palíndromo";}
}

