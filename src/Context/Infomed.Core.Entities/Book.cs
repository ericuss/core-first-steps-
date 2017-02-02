

namespace Infomed.Core.Entities
{
    using Core;
    using System;
    using System.Collections.Generic;

    public class Book : EntityCore<Guid>
    {
        public Book(string name) : base(Guid.NewGuid())
        {
            this.Name = name;
        }

        public string Name { get; set; }

    }
}
