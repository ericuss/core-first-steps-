using AutoMapper;
using Infomed.Core.Entities;
using Infomed.Core.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Web
{
    public static class Mapper
    {
        public static void Configure(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Author, AuthorDto>()
               .ForMember(destination => destination.NameComplete, map => map.MapFrom(origin => $"{origin.Name} {origin.Name}"));
            cfg.CreateMap<Book, BookDto>();
        }
    }
}
