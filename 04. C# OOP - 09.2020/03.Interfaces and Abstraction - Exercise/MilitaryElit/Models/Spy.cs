using MilitaryElit.Contracts;
using MilitaryElit.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine(base.ToString())
                .AppendLine($"Code Number: {this.CodeNumber}");

            return sb.ToString().TrimEnd();
        }

    }
}
