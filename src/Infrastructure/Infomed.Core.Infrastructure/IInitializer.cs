using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Infrastructure
{
    public interface IInitializer
    {
        void Execute();
    }
}
