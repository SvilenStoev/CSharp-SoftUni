using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace MilitaryElit.Contracts
{
   public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<ISoldier> Privates { get; }

        void AddPrivate(ISoldier @private);

    }
}
