namespace Infomed.Core.Web.Models
{
    using Core;
    using System;
    using System.Collections.Generic;

    public class AuthorDto
    {
        public AuthorDto()
        {
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameComplete { get; set; }
        public string BooksDesc { get; set; }

        public List<BookDto> Books { get; set; }
    }
}
