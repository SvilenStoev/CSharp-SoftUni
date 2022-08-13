namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    public class SandwichMenu
    {
        public Dictionary<string, SandwichPrototype> sandwiches = new Dictionary<string, SandwichPrototype>();

        public SandwichPrototype this[string name]
        {
            get { return sandwiches[name]; }
            set { sandwiches.Add(name, value); }
        }
    }
}
