using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IBuyer : IPerson
    {
        public int Food { get; }

        void BuyFood();


    }
}
