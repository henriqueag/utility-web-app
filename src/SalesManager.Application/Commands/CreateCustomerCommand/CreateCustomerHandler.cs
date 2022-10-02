using MediatR;
using Microsoft.Extensions.Logging;
using SalesManager.Domain.Builders;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Repository;

namespace SalesManager.Application.Commands.CreateCustomerCommand;

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
            .WithErrorCode("customer-build-failed")
            .WithErrorMessage($"Falha na construção do objeto do tipo {nameof(Customer)}")
            .WithFullName(request.FullName)
            .WithCpf(request.Cpf)
            .WithBirthDate(request.BirthDate)
            .WithPhone(request.Phone)
            .WithEmail(request.Email)
            .Build();

        await _repository.Create(customer, cancellationToken);

        return customer.Id;
    }
}
