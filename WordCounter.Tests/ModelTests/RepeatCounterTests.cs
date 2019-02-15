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
  }
}
