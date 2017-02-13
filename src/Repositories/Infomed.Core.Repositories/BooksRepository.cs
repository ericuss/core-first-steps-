namespace Infomed.Core.Repositories
{
    using Context.Sql;
    using Core;
    using Entities;
    using System;

    public class BooksRepository : RepositoryCore<Book, Guid>, IBooksRepository
    {
        public BooksRepository(LibraryContext context) : base(context)
        {
        }
    }
}
