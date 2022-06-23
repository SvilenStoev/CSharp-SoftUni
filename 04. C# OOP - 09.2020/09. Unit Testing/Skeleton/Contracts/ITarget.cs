using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Contracts
{
   public interface ITarget
    {
        bool IsDead { get; }
        int GiveExperience { get; }

        void TakeAttack(int damage);

    }
}
