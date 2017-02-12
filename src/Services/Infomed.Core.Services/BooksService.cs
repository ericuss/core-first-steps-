using Infomed.Core.Context;
using Infomed.Core.Context.Sql;
using Infomed.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Services
{
    public class BooksService : ServiceCore<Book, Guid>, IBooksService
    {
        public BooksService(LibraryContext context) : base(context) { }

        public void Add(Book book)
        {
            this.DbSet.Add(book);
        }
        public List<Book> Get()
        {
            return this.DbSet.ToList();
        }

        public Book GetById(Guid id)
        {
            return this.DbSet.FirstOrDefault(b => b.Id == id);
        }

        public void Update(Guid id, Book raw)
        {
            var bookToUpdate = this.GetById(id);
            if (bookToUpdate != null)
            {
                bookToUpdate.Name = raw.Name;
            }

            this.DbSet.Update(bookToUpdate);
        }

        public void Delete(Guid id)
        {
            var bookToRemove = this.GetById(id);
            if (bookToRemove != null)
            {
                this.DbSet.Remove(bookToRemove);
            }
        }

    }
}
