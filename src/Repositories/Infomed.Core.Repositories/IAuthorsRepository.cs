namespace Infomed.Core.Repositories
{
    using Infomed.Core.Entities;
    using Infomed.Core.Repositories.Core;
    using System;

    public interface IAuthorsRepository : IRepositoryCore<Author, Guid>
    {
    }
}
