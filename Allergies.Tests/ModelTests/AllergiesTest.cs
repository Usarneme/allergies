using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    [TestMethod]
    public void Allergies_One_Eggs()
    {
      Assert.AreEqual("eggs ", AllergiesCount.Allergies.DetermineAllergies(1));
    }

    [TestMethod]
    public void Allergies_Zero_NoAllergies()
    {
      Assert.AreEqual("No allergies", AllergiesCount.Allergies.DetermineAllergies(0));
    }
  }
}
