using System;
namespace AllergiesCount
{
  public class Allergies
  {

    private static string[] allergens = {"eggs","peanuts","shellfish","strawberries","tomatoes","chocolate","pollen","cats"};

    public static string DetermineAllergies(int allergiesScore)
    {
      if (allergiesScore > 255 || allergiesScore < 0)
      {
        return "Not a valid allergy score";
      }

      string binaryScore = Convert.ToString(allergiesScore, 2);
      string returnString = "";

      for (int index = binaryScore.Length-1; index >= 0; index--)
      {
        int indexInAllergensArray = binaryScore.Length - 1 - index;
        if(allergiesScore == 0)
        {
          return "No allergies";
        }

        if(binaryScore[index] == '1')
        {
          returnString += allergens[indexInAllergensArray] + " ";
        }
        //binary string = "100"
        //array.length = 8
        //binaryString.length = 3;
        //8 - 1 - 2 = 5
        //3 - 1 - 2 = 0
        //3 - 1 - 0 = 2
      }
      return returnString;
    }
  }
}

// allergen     score    binary power   binary value
// "eggs"         1        = 2^0          00000001
// "peanuts"      2        = 2^1          00000010
// "shellfish"    4        = 2^2          00000100
// "strawberries" 8        = 2^3          00001000
// "tomatoes"     16       = 2^4          00010000
// "chocolate"    32       = 2*5          00100000
// "pollen"       64       = 2^6          01000000
// "cats"         128      = 2^7          10000000

//  cats+eggs     129      = 128 + 1      10000001
