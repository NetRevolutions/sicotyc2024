using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using sicotyc.repository;

namespace sicotyc.Server.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                b => b.MigrationsAssembly("sicotyc.Server"));

            return new RepositoryContext(builder.Options);
        }
    }
}
