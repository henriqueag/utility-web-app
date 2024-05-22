using Serilog;
using UtilityWebApp.Domain.Services;
using UtilityWebApp.Infra.HttpServices.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, logger) => logger
    .Enrich.WithProperty("Environment", ctx.HostingEnvironment)
    .Enrich.WithProperty("ApplicationName", "utility-web-app")
    .ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAll",
        policy =>
        {
            policy.AllowAnyHeader();
            policy.AllowAnyMethod();
            policy.AllowAnyOrigin();
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient<ISecurityProviderDiscoveryApi, SecurityProviderDiscoveryApi>();

var app = builder.Build();

app.UseCors("AllowAll");
app.MapControllers();

app.UseSerilogRequestLogging(opt => opt.IncludeQueryInRequestPath = true);

app.UseSwagger();
app.UseSwaggerUI();

app.Run();