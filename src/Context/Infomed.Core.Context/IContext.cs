using Infomed.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Context
{
    public interface IContext
    {
        List<Author> Authors { get; set; }
        List<Book> Books { get; set; }
        void LoadBooks();
    }
}
