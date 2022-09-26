using Microsoft.AspNetCore.Mvc.Filters;

namespace SalesManager.Api.Presentation.UnitOfWork;

public class UnitOfWorkAttribute : ActionFilterAttribute
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        // serviços
        var uow = context.HttpContext.RequestServices.GetRequiredService<IUnitOfWork>();

        // Executa normalmente
        await next();

        // Salva as alterações quando for uma requisição de sucesso
        await uow.SaveChangesAsync();
    }
}