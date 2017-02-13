namespace Infomed.Core.Repositories
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class IoC
    {
        public static void Configure(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddScoped<IAuthorsRepository, AuthorsRepository>();
            services.AddScoped<IBooksRepository, BooksRepository>();

            Context.Sql.Ioc.Configure(services, configuration);
        }
    }
}
