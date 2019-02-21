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
    public void TestOneWordAndOneSentence_False()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(0, testRepeatCounter.Count("apple", "orange"));
    }

    [TestMethod]
    public void TestOneWordAndOneSentence_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(1, testRepeatCounter.Count("apple", "apple"));
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

    [TestMethod]
    public void CountWordNotFullyMatchingCase()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(0, testRepeatCounter.Count("I am going to the cathedral", "cat"));
    }

    [TestMethod]
    public void TestBlankSentenceAndBlankWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(false, testRepeatCounter.IsAlphabetical("", ""));
    }

    [TestMethod]
    public void TestBlankWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(false, testRepeatCounter.IsAlphabetical("This is a sentence", ""));
    }

    [TestMethod]
    public void TestBlankSentence()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(false, testRepeatCounter.IsAlphabetical("", "Test"));
    }

    [TestMethod]
    public void CountBlankSentenceAndBlankWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(0, testRepeatCounter.Count("", ""));
    }

    [TestMethod]
    public void CountBlankWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(0, testRepeatCounter.Count("This is a sentence", ""));
    }

    [TestMethod]
    public void CountBlankSentence()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(0, testRepeatCounter.Count("", "Test"));
    }

    [TestMethod]
    public void CountUppercaseSentenceAndLowerCaseWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(1, testRepeatCounter.Count("I am going to France next year", "france"));
    }

    [TestMethod]
    public void CountLowerCaseSentenceAndUpperCaseWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(1, testRepeatCounter.Count("I am going to eat some bananas", "Bananas"));
    }
  }
}
