namespace Infomed.Core.Repositories
{
    using Context.Sql;
    using Core;
    using Entities;
    using System;

    public class AuthorsRepository : RepositoryCore<Author, Guid>, IAuthorsRepository
    {
        public AuthorsRepository(LibraryContext context) : base(context)
        {
        }
    }
}
