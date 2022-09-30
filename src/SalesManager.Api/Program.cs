using SalesManager.Api;
using SalesManager.Api.Extensions;

WebApplication.CreateBuilder(args)
    .ConfigureLogging()
    .UseStartup<Startup>();