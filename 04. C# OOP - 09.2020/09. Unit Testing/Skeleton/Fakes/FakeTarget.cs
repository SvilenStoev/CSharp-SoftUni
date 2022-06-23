using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Fakes
{
    public class FakeTarget : ITarget
    {
        public const int DEFAULT_EXPERIENCE = 100;

        public int GiveExperience => DEFAULT_EXPERIENCE;

        public bool IsDead => true;

        public void TakeAttack(int damage)
        {
           
        }
    }
}
