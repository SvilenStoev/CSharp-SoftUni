using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string url)
        {
            if (url.Any(ch => char.IsDigit(ch)))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (number.Any(num => !char.IsDigit(num)))
            {
                throw new InvalidNumberException();
            }

            return $"Calling... {number}";
        }
    }
}
