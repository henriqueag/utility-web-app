using SalesManager.SalesManager.Api.Runtime.Host.IoC;

namespace SalesManager.SalesManager.Api.Runtime.Host.Extensions;

public class Startup : Interfaces.IStartup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCors(cors =>
        {
            cors.AddDefaultPolicy(policy =>
            {
                policy.AllowAnyOrigin();
                policy.AllowAnyMethod();
                policy.AllowAnyHeader();
            });
        });
        services.AddControllers();
        services.AddRouting(options => options.LowercaseUrls = true);
        services.AddSwagger();
        services.RegisterServices(Configuration);
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        app.ApplyMigrations();
        app.UseSwaggerUI();
        app.UseAuthorization();
        app.UseCors();
        app.MapControllers();
    }
}