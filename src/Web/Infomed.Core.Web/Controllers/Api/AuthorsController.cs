using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infomed.Core.Entities;
using Infomed.Core.Services;
using AutoMapper;
using Infomed.Core.Web.Models;
using Infomed.Core.Domains;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Infomed.Core.Controllers.Api
{
    [Route("api/[controller]")]
    public class AuthorsController : Controller
    {
        private readonly ILibraryUnitOfWork libraryUOW;
        private readonly IMapper mapper;

        public AuthorsController(ILibraryUnitOfWork libraryUOW, IMapper mapper)
        {
            this.libraryUOW = libraryUOW;
            this.mapper = mapper;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<AuthorDto> Get()
        {
            var authors = libraryUOW.AuthorsRepository.Get();
            return mapper.Map<List<AuthorDto>>(authors);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Author Get(Guid id)
        {
            return libraryUOW.AuthorsRepository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Author Author)
        {
            libraryUOW.AuthorsRepository.Create(Author);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Author Author)
        {
            libraryUOW.UpdateAuthor(id, Author);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            libraryUOW.AuthorsRepository.Remove(id);
        }
    }
}
