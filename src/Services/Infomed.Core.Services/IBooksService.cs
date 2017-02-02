using Infomed.Core.Context;
using Infomed.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Services
{
    public interface IBooksService
    {
        void Add(Book book);
        List<Book> Get();
        Book GetById(Guid id);

        void Update(Guid id, Book raw);

        void Delete(Guid id);
    }
}
