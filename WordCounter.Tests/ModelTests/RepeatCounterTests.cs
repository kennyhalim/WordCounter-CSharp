using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void IsWordAlphabetical_False()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(false, testRepeatCounter.IsAlphabetical("apple is great!", "wow"));
    }

    [TestMethod]
    public void IsWordAlphabetical_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(true, testRepeatCounter.IsAlphabetical("I am testing this program", "program"));
    }

    [TestMethod]
    public void IsEatInSentence_False()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(0, testRepeatCounter.Count("I am am testing this program", "eat"));
    }

    [TestMethod]
    public void IsEatInSentence_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(1, testRepeatCounter.Count("I am going to eat after this class", "eat"));
    }

    [TestMethod]
    public void CountTestInSentence()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(3, testRepeatCounter.Count("This is a test to test the test method is working", "test"));
    }

    [TestMethod]
    public void CountTestInInvalidSentence()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(0, testRepeatCounter.Count("This is a test! to test the test method is working", "test"));
    }
  }
}
