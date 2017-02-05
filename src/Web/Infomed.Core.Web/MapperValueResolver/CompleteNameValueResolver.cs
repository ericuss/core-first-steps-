using AutoMapper;
using Infomed.Core.Entities;
using Infomed.Core.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Web.MapperValueResolver
{
     public class CompleteNameValueResolver : IValueResolver<Author, AuthorDto, string>
    {
        public string Resolve(Author source, AuthorDto destination, string member, ResolutionContext context)
        {
            return $"{source.Name} blabla {source.Name}";
        }
    }
}
