using Microsoft.AspNetCore.Mvc;
using SalesManager.Api.Attributes;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Repository;

namespace SalesManager.Api.Controllers;

[ApiController]
[Route(ResourcesRoute)]
public class CustomerResourcesController : ControllerBase
{
    private const string ResourcesRoute = "api/customers/resources";

    private readonly IRepositoryBase<Customer> _repository;
    private readonly ILogger<CustomerResourcesController> _logger;

    public CustomerResourcesController(IRepositoryBase<Customer> repository, ILogger<CustomerResourcesController> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    [UnitOfWork]
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CustomerData customerData, CancellationToken cancellationToken)
    {
        _logger.LogInformation("A operação de cadastro de cliente foi chamada recebendo {@CustomerData} como entrada", customerData);

        var customer = customerData.ToCustomer();

        await _repository.Create(customer, cancellationToken);

        return Created(Request.Path.Value, new { CustomerId = customer.Id });
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("A operação de busca por todos os cadastros de cliente foi chamada");

        var customers = (await _repository.GetAll(cancellationToken))
            .Select(x => x.ToCustomerData());

        return Ok(customers);
    }

    [HttpGet("{customerId:Guid}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid customerId, CancellationToken cancellationToken)
    {
        _logger.LogInformation("A operação de busca por cadastro de cliente por identificador foi chamada recebendo como entrada o id {CustomerId}", customerId);

        var customer = await _repository.GetById(customerId, cancellationToken);

        if(customer is null)
        {
            return NotFound(new
            {
                Code = "get-by-id.entity-not-found",
                Message = "A busca não retornou resultados"
            });
        }

        return Ok(customer.ToCustomerData());
    }

    [UnitOfWork]
    [HttpDelete("{customerId:Guid}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] Guid customerId, CancellationToken cancellationToken)
    {
        _logger.LogInformation("A operação de exclusão de cadastro de cliente foi chamada recebendo como entrada o id {CustomerId}", customerId);

        var customer = await _repository.GetById(customerId, cancellationToken);

        if (customer is null)
        {
            return NotFound(new
            {
                Code = "delete-async.entity-not-found",
                Message = "O identificado passado na rota não corresponde a nenhum cadastro no sistema"
            });
        }

        await _repository.Delete(customer);

        return NoContent();
    }

    [UnitOfWork]
    [HttpPut("{customerId:Guid}")]
    public async Task<IActionResult> UpdateAsync([FromRoute] Guid customerId, [FromBody] CustomerData customerData, CancellationToken cancellationToken)
    {
        _logger.LogInformation("A operação de atualização de cadastro de cliente foi chamada recebendo como entrada o id {CustomerId} e os dados para serem atualizados {@CustomerData}", customerId, customerData);

        var customer = await _repository.GetById(customerId, cancellationToken);

        if (customer is null)
        {
            return NotFound(new
            {
                Code = "update-async.entity-not-found",
                Message = "O identificado passado na rota não corresponde a nenhum cadastro no sistema"
            });
        }

        customer.UpdateCustomer(customerData.ToCustomer());

        await _repository.Update(customer);

        return Ok(customer.ToCustomerData());
    }


}

public class CustomerData
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Cpf { get; set; }
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
}

public static class CustomerDataExtensions
{
    public static Customer ToCustomer(this CustomerData customerData)
    {
        return new Customer(customerData.FullName, customerData.Cpf, customerData.BirthDate, customerData.Phone, customerData.Email, customerData.IsActive);
    }

    public static CustomerData ToCustomerData(this Customer customer)
    {
        return new CustomerData
        {
            Id = customer.Id,
            FullName = customer.FullName,
            Cpf = customer.Cpf,
            BirthDate = customer.BirthDate,
            Phone = customer.Phone,
            Email = customer.Email,
            IsActive = customer.IsActive
        };
    }
}
