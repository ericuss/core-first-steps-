namespace Infomed.Core.Web.Models
{
    using Core;
    using System;
    using System.Collections.Generic;

    public class BookDto
    {
        public BookDto() 
        {
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}
