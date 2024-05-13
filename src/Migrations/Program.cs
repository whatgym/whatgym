using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Migrations.MySQL
{
    internal class Program : IDesignTimeDbContextFactory<FooContext>
    {
        public FooContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // nuget - Microsoft.Extensions.Configuration.Json
                .AddJsonFile("database.json")
                .Build();

            return new FooContext(configuration);
        }
    }
}