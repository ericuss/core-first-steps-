using Infomed.Core.Context;
using Infomed.Core.Context.Sql;
using Infomed.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Services
{
    public class AuthorsService : ServiceCore<Author, Guid>, IAuthorsService
    {
        public AuthorsService(LibraryContext context) : base(context) { }

        public void Add(Author author)
        {
            this.DbSet.Add(author);
        }
        public List<Author> Get()
        {
            return this.DbSet.ToList();
        }

        public Author GetById(Guid id)
        {
            return this.DbSet.FirstOrDefault(b => b.Id == id);
        }

        public void Update(Guid id, Author raw)
        {
            var authorToUpdate = this.GetById(id);
            if (authorToUpdate != null)
            {
                authorToUpdate.Name = raw.Name;
            }

            this.DbSet.Update(authorToUpdate);
        }

        public void Delete(Guid id)
        {
            var authorToRemove = this.GetById(id);
            if (authorToRemove != null)
            {
                this.DbSet.Remove(authorToRemove);
            }
        }
    }
}
