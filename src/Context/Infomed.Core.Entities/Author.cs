

namespace Infomed.Core.Entities
{
    using Core;
    using System;
    using System.Collections.Generic;

    public class Author : EntityCore<Guid>
    {
        public Author():base(Guid.NewGuid())
        {

        }
        public Author(string name) : this()
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
