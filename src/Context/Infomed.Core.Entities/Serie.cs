using Infomed.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Entities
{
    public class Serie : EntityCore<Guid>
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
