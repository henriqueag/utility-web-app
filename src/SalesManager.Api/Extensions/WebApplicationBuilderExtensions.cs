using Serilog;
using Serilog.Filters;

namespace SalesManager.Api.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder builder) where TStartup : Interfaces.IStartup
    {
        if (Activator.CreateInstance(typeof(TStartup), builder.Configuration) is not Interfaces.IStartup startup)
            throw new ArgumentException("Startup class is invalid.");

        startup.ConfigureServices(builder.Services);

        var app = builder.Build();

        startup.Configure(app, app.Environment);
        
        app.Run();

        return builder;
    }

    public static WebApplicationBuilder ConfigureLogging(this WebApplicationBuilder builder)
    {
        builder.Logging.ClearProviders();

        Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Filter.ByExcluding(Matching.FromSource("Microsoft.AspNetCore"))
                .Filter.ByExcluding(Matching.FromSource("Microsoft.EntityFrameworkCore"))
                .WriteTo.Console()
                .CreateLogger();

        builder.Host.UseSerilog(Log.Logger);

        return builder;
    }
}