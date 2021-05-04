using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergiesCount;

namespace Allergies.TestTools
{
  [TestClass]
  public class AllergiesTest
  {
    // private Allergies _allergies = new Allergies();

    [TestMethod]
    public void Allergies_LowerBounds_ErrorMessage()
    {
      Assert.AreEqual("Not a valid allergy score", AllergiesCount.Allergies.DetermineAllergies(-1));
    }

    [TestMethod]
    public void Allergies_UpperBounds_ErrorMessage()
    {
      Assert.AreEqual("Not a valid allergy score", AllergiesCount.Allergies.DetermineAllergies(280));
    }

  }
}
