using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _word;
    private static List<RepeatCounter> _List = new List<RepeatCounter> {};
    private int _id;

    public RepeatCounter (string sentence, string word)
    {
      _sentence = sentence;
      _word = word;
      _List.Add(this);
      _id = _List.Count;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public string GetWord()
    {
      return _word;
    }

    public static List<RepeatCounter> GetAll()
    {
      return _List;
    }

    public static void ClearAll()
    {
      _List.Clear();
    }

    public static RepeatCounter Find(int searchId)
    {
      return _List[searchId-1];
    }

    public int GetId()
    {
     return _id;
    }

    public bool isEmpty()
    {
      if (string.IsNullOrEmpty(_sentence) && string.IsNullOrEmpty(_word)){
        return true;
      }
      return false;
    }

    public bool IsAlphabetical(string sentence, string word)
    {
      if(string.IsNullOrEmpty(_sentence) || string.IsNullOrEmpty(_word)){
        return false;
      }
      string sentenceWord = _sentence + ' ' + _word;
      foreach (char c in sentenceWord)
      {
        if (!Char.IsLetterOrDigit(c) && c != ' ') //Only allow alphabets, numbers and space (No Punctuation)
          return false;
      }
      return true;
    }

    public int Count(){
      int counter = 0;
      string[] wordsInSentence = _sentence.Split(' ');
      if(IsAlphabetical(_sentence, _word)){
        for(int i = 0; i < wordsInSentence.Length; i++){
          if(_word.ToLower() == wordsInSentence[i].ToLower()){
            counter++;
          }
        }
      }
      return counter;
    }
  }
}
