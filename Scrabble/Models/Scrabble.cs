using System.Collections.Generic;
using System;

namespace Scrabble.Models
{
  public class ScrabbleScoreCS
  {
    private int _scoreTotal;
    Dictionary<string, int> LetterValueKey = new Dictionary<string, int>() { {"a", 1}, {"e", 1}, {"i", 1}, {"o", 1}, {"u", 1}, {"l", 1}, {"n", 1}, {"r", 1}, {"s",1}, {"t", 1} };


    public string Scorer(string inputLetter)
    {
      public string Cycle(string inputLetter)
      {
        foreach (KeyValuePair<string, int> letter in LetterValueKey)
        {
          if (inputLetter == letter.Key)
          {
            return letter.Value;
          }
          else if (inputLetter =! char)
          {
            return "Please don't use symbols or integers."
          }
          else
          {
            Cycle();
          }
        }
      }
    }
  }
}
