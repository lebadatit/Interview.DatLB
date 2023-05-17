using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace Interview.DatLB.Data;

public class DatLBEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public DatLBEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DatLBDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DatLBDbContext>()
            .Database
            .MigrateAsync();
    }
}
