

namespace Infomed.Core.Entities
{
    using Core;
    using System;
    using System.Collections.Generic;

    public class Author : EntityCore<Guid>
    {
        public Author(string name) : base(Guid.NewGuid())
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
