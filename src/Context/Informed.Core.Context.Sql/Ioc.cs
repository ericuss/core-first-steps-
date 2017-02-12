using Infomed.Core.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Context.Sql
{
    public static class Ioc
    {
        public static void Configure(IServiceCollection srv, IConfigurationRoot configuration)
        {
            srv.AddDbContext<LibraryContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            srv.AddSingleton<IInitializer, Initializer>();
        }
    }
}
