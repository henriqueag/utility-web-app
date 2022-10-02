using MediatR;
using Microsoft.AspNetCore.Mvc;
using SalesManager.Api.Attributes;
using SalesManager.Application.Commands.CreateCustomerCommand;

namespace SalesManager.Api.Controllers;

[Route(ResourcesRoute)]
public class CustomerResourcesController : AbstractController
{
    private const string ResourcesRoute = "api/customers/resources";

    [UnitOfWork]
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var result = await HandleAsync(request, cancellationToken);

        return Created(Request.Path.Value, result);
    }
}