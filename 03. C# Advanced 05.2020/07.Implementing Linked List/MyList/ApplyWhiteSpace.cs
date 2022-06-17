using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
   public static class StringExtensions
    {
       public static string ApplyWhiteSpace(this string input, int count = 1)
        {
            var whiteSPace = new string(' ', count);
            return $"{whiteSPace}{input}{whiteSPace}";
        }
    }
}
