using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Exceptions
{
    public class InvalidStateException : Exception
    {
        private const string DEF_STATE_MSG = "Invalid mission state!";

        public InvalidStateException()
            :base(DEF_STATE_MSG)
        {

        }

        public InvalidStateException(string message) 
            : base(message)
        {

        }
    }
}
