using Microsoft.AspNetCore.Mvc;
using SalesManager.Api.Attributes;
using SalesManager.Application.Commands.CreateCustomer;
using SalesManager.Application.Commands.DeleteCustomer;
using SalesManager.Application.Commands.UpdateCustomer;
using SalesManager.Application.Dtos;
using SalesManager.Application.Queries.GetAllCustomers;
using SalesManager.Domain.ValueObjects;

namespace SalesManager.Api.Controllers;

[Route(CustomersRoute)]
public class CustomerResourcesController : AbstractController
{
    private const string CustomersRoute = "api/customers/resources";

    [UnitOfWork]
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var result = await HandleAsync(request, cancellationToken);
        var location = $"{CustomersRoute}/{result}";

        return Created(location, result);
    }

    [UnitOfWork]
    [HttpPut("{customerId:Guid}")]
    public async Task<IActionResult> UpdateAsync([FromRoute] Guid customerId, [FromBody] CustomerData data, CancellationToken cancellationToken)
    {
        var request = new UpdateCustomerCommand(customerId, data);
        await HandleAsync(request, cancellationToken);

        return NoContent();
    }

    [UnitOfWork]
    [HttpDelete("{customerId:Guid}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] Guid customerId, CancellationToken cancellationToken)
    {
        var request = new DeleteCustomerCommand(customerId);        
        await HandleAsync(request, cancellationToken);

        return NoContent();
    }

    [HttpGet("{customerId:Guid}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid customerId, CancellationToken cancellationToken)
    {
        var request = new GetCustomerQuery(customerId);
        var result = await HandleAsync(request, cancellationToken);

        if (result is null)
        {
            var error = new ErrorMessage
            {
                Code = "get-customer-query.entity-not-found",
                Message = "Cadastro não encontrado"
            };

            return NotFound(error);
        }

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        var request = new GetAllCustomersQuery();
        var result = await HandleAsync(request, cancellationToken);

        return Ok(result);
    }
}