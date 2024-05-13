﻿namespace whatgym.api.Configurations
{
    internal static class Startup
    {
        internal static WebApplicationBuilder AddConfigurations(this WebApplicationBuilder builder) 
        {
            const string configurationsDirectory = nameof(Configurations);

            var env = builder.Environment;

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"{configurationsDirectory}/database.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"{configurationsDirectory}/database.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            return builder;
        }
    }
}
