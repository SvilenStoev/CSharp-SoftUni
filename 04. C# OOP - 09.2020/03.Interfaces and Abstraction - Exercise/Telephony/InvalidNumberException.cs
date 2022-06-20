using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class InvalidNumberException : Exception
    {
        const string EXC_MSG = "Invalid number!";

        public InvalidNumberException()
            : base(EXC_MSG)
        {
        }

        public InvalidNumberException(string message)
            : base(message)
        {
        }
    }
}
