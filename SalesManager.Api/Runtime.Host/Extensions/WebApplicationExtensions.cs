using Microsoft.EntityFrameworkCore;
using SalesManager.Api.Provider.EntityFramework.SqlServer;

namespace SalesManager.SalesManager.Api.Runtime.Host.Extensions;

public static class WebApplicationExtensions
{
    public static void ApplyMigrations(this WebApplication app)
    {
        using var serviceScope = app.Services.CreateScope();

        var logger = serviceScope.ServiceProvider.GetRequiredService<ILogger<Startup>>();
        var context = serviceScope.ServiceProvider.GetRequiredService<SqlServerDbContext>();

        var pendingMigrations = context.Database.GetPendingMigrations();

        if (pendingMigrations.Any())
        {
            logger.LogInformation("Migrations pendentes: {Migrations}", string.Join(", ", pendingMigrations));
            logger.LogInformation("Aplicando migrations no banco de dados...");

            context.Database.Migrate();
        }

        logger.LogInformation("Banco de dados atualizado");
    }
}
