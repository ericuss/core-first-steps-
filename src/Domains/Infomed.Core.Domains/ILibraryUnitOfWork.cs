using Infomed.Core.Context.Sql;
using Infomed.Core.Entities;
using Infomed.Core.Repositories;
using Infomed.Core.Repositories.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Domains
{
    public interface ILibraryUnitOfWork
    {
        IAuthorsRepository AuthorsRepository { get; }
        IBooksRepository BooksRepository { get; }

        void UpdateAuthor(Guid id, Author authorRaw);

        void UpdateBook(Guid id, Book bookRaw);
    }
}
