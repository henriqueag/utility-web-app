using Infrastructure;
using Runtime.Host.Extensions;
using Runtime.Host.IoC;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Runtime.Host;

public class Startup : Interfaces.IStartup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc()
            .AddApplicationPart(typeof(Application.Module).Assembly);

        services.AddCors(cors =>
        {
            cors.AddDefaultPolicy(policy =>
            {
                policy.AllowAnyOrigin();
                policy.AllowAnyMethod();
                policy.AllowAnyHeader();
            });
        });
        services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });
        services.AddRouting(options => options.LowercaseUrls = true);
        services.AddSwagger();
        services.RegisterServices(Configuration);
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        app.UseSwaggerUI();
        app.UseAuthorization();
        app.UseCors();
        app.MapControllers();
        app.Services.ApplyMigrations();
    }
}