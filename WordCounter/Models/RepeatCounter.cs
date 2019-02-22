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
    public bool IsAlphabetical(string sentence, string word)
    {
      if(string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(word)){
        return false;
      }
      string sentenceWord = sentence + ' ' + word;
      foreach (char c in sentenceWord)
      {
        if (!Char.IsLetterOrDigit(c) && c != ' ') //Only allow alphabets, numbers and space (No Punctuation)
          return false;
      }
      return true;
    }

    public int Count(string sentence, string word){
      int counter = 0;
      string[] wordsInSentence = sentence.Split(' ');
      if(IsAlphabetical(sentence, word)){
        for(int i = 0; i < wordsInSentence.Length; i++){
          if(word.ToLower() == wordsInSentence[i].ToLower()){
            counter++;
          }
        }
      }
      return counter;
    }
  }
}
