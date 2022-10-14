using Serilog;

namespace Runtime.Host.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder builder) where TStartup : Interfaces.IStartup
    {
        if (Activator.CreateInstance(typeof(TStartup), builder.Configuration) is not Interfaces.IStartup startup)
            throw new ArgumentException("Startup class is invalid.");

        startup.ConfigureServices(builder.Services);

        var app = builder.Build();
        app.UseSerilogRequestLogging();
        
        startup.Configure(app, app.Environment);        
        
        app.Run();

        return builder;
    }

    public static WebApplicationBuilder ConfigureLogging(this WebApplicationBuilder builder)
    {
        builder.Logging.ClearProviders();
        
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .ReadFrom.Configuration(builder.Configuration)
            .Enrich.FromLogContext()
            .Enrich.WithMachineName()
            .Enrich.WithProperty("ApplicationName", "Sales Manager")
            .Enrich.WithProperty("ApplicationVersion", "1.0.0")
            .Enrich.WithProperty("EnvironmentName", builder.Environment.EnvironmentName)
            .WriteTo.Console()
            .CreateLogger();

        builder.Host.UseSerilog(Log.Logger);

        return builder;
    }
}