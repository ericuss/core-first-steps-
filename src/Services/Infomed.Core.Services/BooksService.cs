using Infomed.Core.Context;
using Infomed.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Services
{
    public class BooksService : IBooksService
    {
        private IContext context;

        public BooksService(IContext context)
        {
            this.context = context;
        }
        public void Add(Book book)
        {
            this.context.Books.Add(book);
        }
        public List<Book> Get()
        {
            return this.context.Books;
        }

        public Book GetById(Guid id)
        {
            return this.context.Books.FirstOrDefault(b => b.Id == id);
        }

        public void Update(Guid id, Book raw)
        {
            var bookToUpdate = this.GetById(id);
            if (bookToUpdate != null)
            {
                bookToUpdate.Name = raw.Name;
            }
        }

        public void Delete(Guid id)
        {
            var bookToRemove = this.GetById(id);
            if (bookToRemove != null)
            {
                this.context.Books.Remove(bookToRemove);
            }
        }

    }
}
