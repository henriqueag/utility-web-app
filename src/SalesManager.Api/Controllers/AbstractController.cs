using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SalesManager.Api.Controllers;

[ApiController]
public class AbstractController : ControllerBase
{
    /// <summary>
    /// Trata a execução de um command/query
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    protected async Task<T> HandleAsync<T>(IRequest<T> request, CancellationToken cancellationToken)
    {
        var sender = HttpContext.RequestServices.GetRequiredService<ISender>();
        var result = await sender.Send(request, cancellationToken);

        return result;
    }
}