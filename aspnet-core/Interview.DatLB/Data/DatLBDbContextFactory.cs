using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Interview.DatLB.Data;

public class DatLBDbContextFactory : IDesignTimeDbContextFactory<DatLBDbContext>
{
    public DatLBDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DatLBDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new DatLBDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
