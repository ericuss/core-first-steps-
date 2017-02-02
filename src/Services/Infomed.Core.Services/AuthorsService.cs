using Infomed.Core.Context;
using Infomed.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Services
{
    public class AuthorsService : IAuthorsService
    {
        private IContext context;

        public AuthorsService(IContext context)
        {
            this.context = context;
        }
        public void Add(Author author)
        {
            this.context.Authors.Add(author);
            this.context.LoadBooks();
        }
        public List<Author> Get()
        {
            return this.context.Authors;
        }

        public Author GetById(Guid id)
        {
            return this.context.Authors.FirstOrDefault(b => b.Id == id);
        }

        public void Update(Guid id, Author raw)
        {
            var authorToUpdate = this.GetById(id);
            if (authorToUpdate != null)
            {
                authorToUpdate.Name = raw.Name;
            }
        }

        public void Delete(Guid id)
        {
            var authorToRemove = this.GetById(id);
            if (authorToRemove != null)
            {
                this.context.Authors.Remove(authorToRemove);
            }
        }
    }
}
