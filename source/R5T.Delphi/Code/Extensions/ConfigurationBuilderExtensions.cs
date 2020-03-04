using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Suebia;


namespace R5T.Delphi
{
    public static class ConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddDatabaseServerAuthentications(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            var secretsFilePathProvider = configurationServiceProvider.GetRequiredService<ISecretsDirectoryFilePathProvider>();

            var secretsFilePath = secretsFilePathProvider.GetSecretsFilePath(FileNames.DatabaseAuthenticationsJsonFileName);

            configurationBuilder.AddJsonFile(secretsFilePath);

            return configurationBuilder;
        }
    }
}
