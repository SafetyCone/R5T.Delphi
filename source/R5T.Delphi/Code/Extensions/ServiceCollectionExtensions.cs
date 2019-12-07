using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Anactorium;
using R5T.Sardinia;

using RawDatabaseServerAuthentications = R5T.Anactorium.Raw.DatabaseServerAuthentications;


namespace R5T.Delphi
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabaseServerAuthentications(this IServiceCollection services)
        {
            services
                .AddOptions()
                .Configure<RawDatabaseServerAuthentications>()
                .ConfigureOptions<DatabaseServerAuthenticationsConfigureOptions>()
                ;

            return services;
        }
    }
}
