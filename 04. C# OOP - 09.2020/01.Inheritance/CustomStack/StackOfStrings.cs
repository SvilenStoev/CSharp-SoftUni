using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return base.Count == 0;
        }

        public void AddRange(IEnumerable<string> values)
        {
            foreach (var value in values)
            {
                base.Push(value);
            }
        }

    }
}
