using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Code.Code
{

    public class C_TitleCase
    {
        public static string TitleCase(string title, string minorWords = "")
        {
          if (title.Trim(' ') == "") return title;

          string[] titleArray = title.Split(' ');

          for (int Num = 0; Num < titleArray.Length; Num++)
          {
              titleArray[Num] = titleArray[Num][0].ToString().ToUpper() + titleArray[Num].Substring(1).ToLower();
          }

          if (minorWords != "" && minorWords != null)
          {
              string[] minorWordsArray = minorWords.Split(' ');
              for (int Num = 1; Num < titleArray.Length; Num++)
              {
                  if (minorWordsArray.Any(mw => mw.ToLower() == titleArray[Num].ToLower()))
                  {
                      titleArray[Num] = titleArray[Num].ToLower();
                  }
              }
          }
          return string.Join(" ", titleArray);          
        }
    }
}

/*A string is considered to be in title case if each word in the string is either(a) capitalised(that is, only the first letter of the word is in upper case) or(b) 
 * considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.
Write a function that will convert a string into title case, given an optional list of exceptions (minor words). The list of minor words will be given as a string 
with each word separated by a space. Your function should ignore the case of the minor words string -- it should behave in the same way even if the case of the minor word string is changed.

Arguments (Haskell)
First argument: space-delimited list of minor words that must always be lowercase except for the first word in the string.
Second argument: the original string to be converted.
}*/
