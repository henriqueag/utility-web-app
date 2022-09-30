using SalesManager.Domain.Entities;
using SalesManager.Provider.EntityFramework;

namespace SalesManager.Api.Extensions;

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

        CreateInitialData(context, logger);

        logger.LogInformation("Banco de dados atualizado");
    }

    public static void CreateInitialData(SqlServerDbContext context, ILogger<Startup> logger)
    {
        var products = new List<Product>
        {
            new("Agua saborizada Sabor limão", 5, 3.99M, 1.68M, true),
            new("Sabonete dove caixa com 6", 4, 17.99M, 8.76M, true),
            new("Desinfetante Eucalipto 1 Litro", 10, 8.79M, 4.59M, true)
        };

        var customers = new List<Customer>
        {
            new("Cliente 1", "111.111.111-11", new DateTime(1998, 03, 23), "(37) 99999-9999", "cliente1@email.com", true),
            new("Cliente 2", "222.222.222-22", new DateTime(1998, 04, 15), "(37) 98888-8888", "cliente2@email.com", true),
            new("Cliente 3", "333.333.333-33", new DateTime(1998, 05, 9), "(37) 97777-7777", "cliente3@email.com", true),
        };

        var paymentMethods = new List<PaymentMethod>
        {
            new("Crédito 1X", false),
            new("Débito", true),
            new("Pix", true)
        };

        if (!context.Set<Product>().Any())
        {
            logger.LogInformation("Adicionado carga inicial de produtos no banco de dados");
            context.AddRange(products);
        }

        if (!context.Set<Customer>().Any())
        {
            logger.LogInformation("Adicionado carga inicial de clientes no banco de dados");
            context.AddRange(customers);
        }

        if (!context.Set<PaymentMethod>().Any())
        {
            logger.LogInformation("Adicionado carga inicial de formas de pagamento no banco de dados");
            context.AddRange(paymentMethods);
        }

        context.SaveChanges();
    }
}