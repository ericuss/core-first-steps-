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
    public class LibraryUnitOfWork : ILibraryUnitOfWork
    {
        private readonly LibraryContext context;
        public IAuthorsRepository AuthorsRepository { get; private set; }
        public IBooksRepository BooksRepository { get; private set; }

        public LibraryUnitOfWork(LibraryContext context, IAuthorsRepository authorsRepository, IBooksRepository booksRepository)
        {
            this.context = context;
            this.AuthorsRepository = authorsRepository;
            this.BooksRepository = booksRepository;
        }

        public void UpdateAuthor(Guid id, Author authorRaw)
        {
            var author = this.AuthorsRepository.Get(id);
            if (author != null)
            {
                author.Name = authorRaw.Name;
            }
        }

        public void UpdateBook(Guid id, Book bookRaw)
        {
            var book = this.BooksRepository.Get(id);
            if (book != null)
            {
                book.Name = bookRaw.Name;
            }
        }


    }
}
