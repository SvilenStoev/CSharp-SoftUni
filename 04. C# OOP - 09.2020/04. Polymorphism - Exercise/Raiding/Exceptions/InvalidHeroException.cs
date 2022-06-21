using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Exceptions
{
    public class InvalidHeroException : Exception
    {
        private const string INVALID_HERO_EXCEPTION_MESSAGE = "Invalid hero!";

        public InvalidHeroException()
            : base(INVALID_HERO_EXCEPTION_MESSAGE)
        {
        }

        public InvalidHeroException(string message)
            : base(message)
        {
        }
    }
}
