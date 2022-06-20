using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Contracts
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
