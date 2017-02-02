using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Infomed.Core.Services
{
    public static class IoC
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IBooksService, BooksService>();
            services.AddScoped<IAuthorsService, AuthorsService>();

            Context.IoC.Configure(services);
        }
    }
}
