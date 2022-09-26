using SalesManager.SalesManager.Api.Runtime.Host.Extensions;

WebApplication.CreateBuilder(args)
    .ConfigureLogging()
    .UseStartup<Startup>();