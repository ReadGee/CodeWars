using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Code
{
    internal class Your_order__please
    {
        public static string Order(string words)
        {
            if (words == "" || words == null) return words;
            string[] arrayWords = words.Split(" ");
            string[] arrayFinalWords = new string[arrayWords.Length];

            for (int i = 0; i < arrayWords.Length; i++)
            {
                foreach (char word in arrayWords[i])
                {
                    if (word >= '1' && word <= '9')
                    {
                        arrayFinalWords[Convert.ToInt32(new string(word, 1)) - 1] = arrayWords[i];
                        break;
                    }
                }
            }
            return string.Join(" ", arrayFinalWords);
        }
    }
}
