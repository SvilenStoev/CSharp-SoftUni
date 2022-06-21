using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Contracts
{
    public interface IBaseHero
    {
        string Name { get; }

        int Power { get; }

        string CastAbility();
    }
}
