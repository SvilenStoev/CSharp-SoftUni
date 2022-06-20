using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Contracts
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
