using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Runtime.Host.Extensions;

public static class SwaggerSetup
{
    public static void AddSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {            
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "SalesManager.Api",
                Description = "Sistema básico que executa operações CRUD e é composto por relacionamento entre entidades",
                Contact = new OpenApiContact 
                { 
                    Name = "Henrique Aguiar",
                    Email = "henriquesantos.ag2@gmail.com",
                    Url = new Uri("https://github.com/henriqueag")
                },
                Version = "v1"
            });

            var xmlFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.xml");
            
            foreach (var filename in xmlFiles)
            {
                options.IncludeXmlComments(filename);
            }
        });
    }

    public static void UseSwaggerUI(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "API interna");
            options.DocExpansion(DocExpansion.List);
        });
    }
}