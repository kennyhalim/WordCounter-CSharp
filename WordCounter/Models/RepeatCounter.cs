using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    public bool IsAlphabetical(string sentence, string word)
    {
      string sentenceWord = sentence + ' ' + word;
      foreach (char c in sentenceWord)
      {
        if (!Char.IsLetterOrDigit(c) && c != ' ')
          return false;
      }
      return true;
    }

    public int Count(string sentence, string word){
      
    }
  }
}
