

namespace Infomed.Core.Entities
{
    using Core;
    using System;
    using System.Collections.Generic;

    public class Book : EntityCore<Guid>
    {
        public Book() : base(Guid.NewGuid())
        {

        }
        public Book(string name) : this()
        {
            this.Name = name;
        }

        public string Name { get; set; }

    }
}
