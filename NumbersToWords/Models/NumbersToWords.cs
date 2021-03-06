using System;

namespace NumbersToWords.Models
{
  public class Numbers
  {
    private int _numbers;
    private static Dictionary<string, string> numbersUnderNineteen = new Dictionary<string,string>()
    {
      {"0", "zero"}, {"1", "one"}, {"2", "two"}, {"3", "three"}, {"4", "four"}, {"5", "five"}, {"6", "six"}, {"7", "seven"}, {"8", "eight"}, {"9", "nine"}, {"10", "ten"}, {"11", "eleven"}, {"12", "twelve"}, {"13", "thirteen"}, {"14", "fourteen"}, {"15", "fifteen"}, {"16", "sixteen"}, {"17", "seventeen"}, {"18", "eighteen"}, {"19", "nineteen"}
    }

    private static Dictionary<string, string> numbersTens = new Dictionary<string, string>()
    {
      {"2", "twenty-"}, {"3", "thirty-"}, {"4", "forty-"}, {"5", "fifty"}, {"6", "sixty"}, {"7", "seventy"}, {"8", "eighty"}, {"9", "ninety"}
    }

    
  }
}
