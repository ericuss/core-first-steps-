namespace Infomed.Core.Domains
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class IoC
    {
        public static void Configure(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddScoped<ILibraryUnitOfWork, LibraryUnitOfWork>();
            Repositories.IoC.Configure(services, configuration);
        }
    }
}
