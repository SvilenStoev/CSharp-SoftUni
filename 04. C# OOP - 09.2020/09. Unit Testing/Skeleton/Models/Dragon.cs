using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
    public class Dragon
    {
        private IIntroducer introducer;

        public Dragon(string name, IIntroducer introducer)
        {
            this.Name = name;
            this.introducer = introducer;
        }

        public string Name { get; }

        public void Introduce()
        {
            this.introducer.Introduce($"I am {this.Name} and I am blue and nice.");
        }

    }
}
