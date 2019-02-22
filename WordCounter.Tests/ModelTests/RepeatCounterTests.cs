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
      RepeatCounter testRepeatCounter = new RepeatCounter("apple is great!", "wow");
      Assert.AreEqual(false, testRepeatCounter.IsAlphabetical("apple is great!", "wow"));
    }

    [TestMethod]
    public void IsWordAlphabetical_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("I am testing this program", "program");
      Assert.AreEqual(true, testRepeatCounter.IsAlphabetical("I am testing this program", "program"));
    }

    [TestMethod]
    public void TestOneWordAndOneSentence_False()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("apple", "orange");
      Assert.AreEqual(0, testRepeatCounter.Count());
    }

    [TestMethod]
    public void TestOneWordAndOneSentence_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("apple", "apple");
      Assert.AreEqual(1, testRepeatCounter.Count());
    }

    [TestMethod]
    public void IsEatInSentence_False()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("I am am testing this program", "eat");
      Assert.AreEqual(0, testRepeatCounter.Count());
    }

    [TestMethod]
    public void IsEatInSentence_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("I am going to eat after this class", "eat");
      Assert.AreEqual(1, testRepeatCounter.Count());
    }

    [TestMethod]
    public void CountTestInSentence()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("This is a test to test the test method is working", "test");
      Assert.AreEqual(3, testRepeatCounter.Count());
    }

    [TestMethod]
    public void CountTestInInvalidSentence()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("This is a test! to test the test method is working", "test");
      Assert.AreEqual(0, testRepeatCounter.Count());
    }

    [TestMethod]
    public void CountWordNotFullyMatchingCase()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("I am going to the cathedral", "cat");
      Assert.AreEqual(0, testRepeatCounter.Count());
    }

    [TestMethod]
    public void TestBlankSentenceAndBlankWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("", "");
      Assert.AreEqual(false, testRepeatCounter.IsAlphabetical("", ""));
    }

    [TestMethod]
    public void TestBlankWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("This is a sentence", "");
      Assert.AreEqual(false, testRepeatCounter.IsAlphabetical("This is a sentence", ""));
    }

    [TestMethod]
    public void TestBlankSentence()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("", "Test");
      Assert.AreEqual(false, testRepeatCounter.IsAlphabetical("", "Test"));
    }

    [TestMethod]
    public void CountBlankSentenceAndBlankWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("", "");
      Assert.AreEqual(0, testRepeatCounter.Count());
    }

    [TestMethod]
    public void CountBlankWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("This is a sentence", "");
      Assert.AreEqual(0, testRepeatCounter.Count());
    }

    [TestMethod]
    public void CountBlankSentence()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("", "Test");
      Assert.AreEqual(0, testRepeatCounter.Count());
    }

    [TestMethod]
    public void CountUppercaseSentenceAndLowerCaseWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("I am going to France next year", "france");
      Assert.AreEqual(1, testRepeatCounter.Count());
    }

    [TestMethod]
    public void CountLowerCaseSentenceAndUpperCaseWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("I am going to eat some bananas", "Bananas");
      Assert.AreEqual(1, testRepeatCounter.Count());
    }
  }
}
