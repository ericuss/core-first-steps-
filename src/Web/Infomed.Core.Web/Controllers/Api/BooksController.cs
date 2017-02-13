using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infomed.Core.Entities;
using Infomed.Core.Services;
using Infomed.Core.Domains;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Infomed.Core.Controllers.Api
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly ILibraryUnitOfWork libraryUOW;

        public BooksController(ILibraryUnitOfWork libraryUOW)
        {
            this.libraryUOW = libraryUOW;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return libraryUOW.BooksRepository.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(Guid id)
        {
            return libraryUOW.BooksRepository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Book book)
        {
            libraryUOW.BooksRepository.Create(book);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Book book)
        {
            libraryUOW.UpdateBook(id, book);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            libraryUOW.BooksRepository.Remove(id);
        }
    }
}
