using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Contracts
{
    interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
