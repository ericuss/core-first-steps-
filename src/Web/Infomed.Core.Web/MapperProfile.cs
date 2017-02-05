using AutoMapper;
using Infomed.Core.Entities;
using Infomed.Core.Web.MapperValueResolver;
using Infomed.Core.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Web
{
    public class MapperProfile : Profile
    {
        public MapperProfile() : this("DtoMapperProfile")
        {
        }
        protected MapperProfile(string profileName) : base(profileName)
        {
            CreateMap<Author, AuthorDto>()
               .ForMember(destination => destination.NameComplete, map => map.ResolveUsing<CompleteNameValueResolver>())
               .ForMember(destination => destination.BooksDesc, map => map.MapFrom(origin => string.Join(", ", origin.Books.Select(b => b.Name))))
               
               ;
            CreateMap<Book, BookDto>();
        }
    }
}
