using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infomed.Core.Entities;
using Infomed.Core.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Infomed.Core.Controllers.Api
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBooksService service;

        public BooksController(IBooksService bookService)
        {
            this.service = bookService;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return service.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(Guid id)
        {
            return service.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Book book)
        {
            service.Add(book);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Book book)
        {
            service.Update(id, book);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            service.Delete(id);
        }
    }
}
