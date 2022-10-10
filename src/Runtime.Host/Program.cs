using Runtime.Host;
using Runtime.Host.Extensions;

WebApplication.CreateBuilder(args)
    .ConfigureLogging()
    .UseStartup<Startup>();