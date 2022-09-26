namespace SalesManager.SalesManager.Api.Runtime.Host.Interfaces;

public interface IStartup
{
    IConfiguration Configuration { get; }
    void ConfigureServices(IServiceCollection services);
    void Configure(WebApplication app, IWebHostEnvironment env);
}
