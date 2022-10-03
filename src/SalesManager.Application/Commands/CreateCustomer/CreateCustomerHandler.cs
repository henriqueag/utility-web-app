using MediatR;
using Microsoft.Extensions.Logging;
using SalesManager.Application.Extensions;
using SalesManager.Domain.Builders;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Repository;

namespace SalesManager.Application.Commands.CreateCustomer;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Guid>
{
    private readonly IRepositoryBase<Customer> _repository;
    private readonly ICustomerBuilder _builder;
    private readonly ILogger<CreateCustomerCommand> _logger;

    public CreateCustomerHandler(IRepositoryBase<Customer> repository, ICustomerBuilder builder, ILogger<CreateCustomerCommand> logger)
    {
        _repository = repository;
        _builder = builder;
        _logger = logger;
    }

    public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("O comando {CommandName} foi solicitado recebendo de entrada o objeto {@Request}", nameof(CreateCustomerCommand), request);

        var customer = _builder
            .WithCpf(request.Cpf)
            .FromCustomerData(request)
            .Build();

        await _repository.Create(customer, cancellationToken);

        return customer.Id;
    }
}
