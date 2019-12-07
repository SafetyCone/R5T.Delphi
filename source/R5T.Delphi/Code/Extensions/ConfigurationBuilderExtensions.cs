using System;

using Microsoft.Extensions.Configuration;

using R5T.Scotia;


namespace R5T.Delphi
{
    public static class ConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddDatabaseServerAuthentications(this IConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.AddUserSecretsFileRivetLocation(FileNames.DatabaseAuthenticationsJsonFileName);

            return configurationBuilder;
        }
    }
}
