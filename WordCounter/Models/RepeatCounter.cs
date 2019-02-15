using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    public bool IsAlphabetical(string sentence, string word)
    {
      if(string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(word)){
        return false;
      }
      string sentenceWord = sentence + ' ' + word;
      foreach (char c in sentenceWord)
      {
        if (!Char.IsLetterOrDigit(c) && c != ' ')
          return false;
      }
      return true;
    }

    public int Count(string sentence, string word){
      int counter = 0;
      string[] wordsInSentence = sentence.Split(' ');
      if(IsAlphabetical(sentence, word)){
        for(int i = 0; i < wordsInSentence.Length; i++){
          if(word == wordsInSentence[i]){
            counter++;
          }
        }
      }
      return counter;
    }
  }
}
