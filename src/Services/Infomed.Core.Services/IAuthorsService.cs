using Infomed.Core.Context;
using Infomed.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Services
{
    public interface IAuthorsService
    {
        void Add(Author author);
        List<Author> Get();
        Author GetById(Guid id);

        void Update(Guid id, Author raw);

        void Delete(Guid id);
    }
}
