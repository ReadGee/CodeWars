using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Code
{
    public static class StringExtensions
    {
        public static string Repeat(this string value, int count) => string.Concat(Enumerable.Repeat(value, count));
    }
    public class Diamond
    {

        public static string print(int n)
        {
            if (n % 2 == 0 || n < 1) return null;

            var result = new System.Text.StringBuilder();
            for (int i = 1; i <= n; i += 2)
            {
                string line = new string(' ', (n - i) / 2) + new string('*', i);
                result.AppendLine(line);
            }
            for (int i = n - 2; i > 0; i -= 2)
            {
                string line = new string(' ', (n - i) / 2) + new string('*', i);
                result.AppendLine(line);
            }
            return result.ToString();
        }
    }
}
