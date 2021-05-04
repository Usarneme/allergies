// using System;
// using System.Collections.Generic;

namespace AllergiesCount
{
  public class Allergies
  {
    public static string DetermineAllergies(int allergiesScore)
    {
      if (allergiesScore > 255 || allergiesScore < 0)
      {
        return "Not a valid allergy score";
      }
      return "Hi";
    }
  }
}

// allergen     score    binary power   binary value
// eggs         1        = 2^0          00000001
// peanuts      2        = 2^1          00000010
// shellfish    4        = 2^2          00000100
// strawberries 8        = 2^3          00001000
// tomatoes     16       = 2^4          00010000
// chocolate    32       = 2*5          00100000
// pollen       64       = 2^6          01000000
// cats         128      = 2^7          10000000

// cats+eggs                            10000001
