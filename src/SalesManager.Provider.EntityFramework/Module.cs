using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SalesManager.Application.UnitOfWork;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Repository;
using SalesManager.Provider.EntityFramework.Repositories;

namespace SalesManager.Provider.EntityFramework;

public static class Module
{
    public static void RegisterProviderServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<SqlServerDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("Default")
                .Replace("{AttachDBFilename}", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SalesManager.mdf"));

            options.UseSqlServer(connectionString);
        });

        services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<IUnitOfWork>(sp => sp.GetRequiredService<SqlServerDbContext>());
    }

    public static void ApplyMigrations(this IServiceProvider service)
    {
        using var serviceScope = service.CreateScope();

        var logger = serviceScope.ServiceProvider.GetRequiredService<ILogger<SqlServerDbContext>>();
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

    public static void CreateInitialData(SqlServerDbContext context, ILogger logger)
    {
        var random = new Random();

        var product1 = new Product("Agua saborizada Sabor limão", 5, 3.99M, 1.68M, true);
        var product2 = new Product("Sabonete dove caixa com 6", 4, 17.99M, 8.76M, true);
        var product3 = new Product("Desinfetante Eucalipto 1 Litro", 10, 8.79M, 4.59M, true);

        var customer1 = new Customer("Cliente 1", "111.111.111-11", new DateTime(1998, 03, 23), "(37) 99999-9999", "cliente1@email.com");
        var customer2 = new Customer("Cliente 2", "222.222.222-22", new DateTime(1998, 04, 15), "(37) 98888-8888", "cliente2@email.com");
        var customer3 = new Customer("Cliente 3", "333.333.333-33", new DateTime(1998, 05, 9), "(37) 97777-7777", "cliente3@email.com");

        var payment1 = new PaymentMethod("Crédito 1X", false);
        var payment2 = new PaymentMethod("Débito", true);
        var payment3 = new PaymentMethod("Pix", true);

        var saleOrderItem1 = new SaleOrderItem(product1, random.Next(), Convert.ToDecimal(random.NextDouble()));
        var saleOrderItem2 = new SaleOrderItem(product2, random.Next(), Convert.ToDecimal(random.NextDouble()));

        var items = new List<SaleOrderItem>() { saleOrderItem1, saleOrderItem2 };

        var saleOrder1 = new SaleOrder(
            customer1,
            payment1,
            items,
            Convert.ToDecimal(random.NextDouble()),
            Convert.ToDecimal(random.NextDouble()),
            Convert.ToDecimal(random.NextDouble()),
            Convert.ToDecimal(random.NextDouble())
            );

        var saleOrder2 = new SaleOrder(
            customer2,
            payment1,
            items,
            Convert.ToDecimal(random.NextDouble()),
            Convert.ToDecimal(random.NextDouble()),
            Convert.ToDecimal(random.NextDouble()),
            Convert.ToDecimal(random.NextDouble())
            );

        var products = new Product[] { product1, product2, product3 };
        var customers = new Customer[] { customer1, customer2, customer3 };
        var paymentMethods = new PaymentMethod[] { payment1, payment2, payment3 };

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

        if (!context.Set<SaleOrder>().Any())
        {
            logger.LogInformation("Adicionado carga inicial de vendas no banco de dados");
            context.Add(saleOrder1);
            context.Add(saleOrder2);
        }

        context.SaveChanges();
    }
}
