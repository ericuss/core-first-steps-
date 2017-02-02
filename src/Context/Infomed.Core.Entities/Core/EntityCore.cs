using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Entities.Core
{
    public abstract class EntityCore<T>
    {
        public EntityCore()
        {
        }
        public EntityCore(T id)
        {
            this.Id = id;
        }
        public T Id { get; set; }
    }
}
