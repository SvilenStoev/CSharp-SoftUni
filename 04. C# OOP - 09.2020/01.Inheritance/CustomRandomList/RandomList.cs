using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            var random = new Random();

            var randomIndex = random.Next(0, base.Count);

            var removedElement = base[randomIndex];

            base.RemoveAt(randomIndex);

            return removedElement;
        }
    }
}
