using MediatR;
using Microsoft.Extensions.Logging;
using SalesManager.Application.Extensions;
using SalesManager.Domain.Builders;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Exceptions;
using SalesManager.Domain.Repository;

namespace SalesManager.Application.Commands.UpdateCustomer;

public class DeleteCustomerHandler : IRequestHandler<UpdateCustomerCommand, Unit>
{
    private readonly IRepositoryBase<Customer> _repository;
    private readonly ICustomerBuilder _builder;
    private readonly ILogger<UpdateCustomerCommand> _logger;

    public DeleteCustomerHandler(IRepositoryBase<Customer> repository, ICustomerBuilder builder, ILogger<UpdateCustomerCommand> logger)
    {
        _repository = repository;
        _builder = builder;
        _logger = logger;
    }

    public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("O comando {CommandName} foi solicitado recebendo de entrada o objeto {@Request}", nameof(UpdateCustomerCommand), request);

        var customer = await _repository.GetById(request.Id, cancellationToken);

        if (customer is null)
        {
            throw new UserFriendlyException("update-customer-command.entity-not-found",
                "Falha na atualização. Cadastro não encontrado");
        }

        var customerUpdated = _builder
            .WithCpf(customer.Cpf)
            .FromCustomerData(request.Data)
            .Build();

        customer.UpdateCustomer(customerUpdated);

        await _repository.Update(customer);

        return Unit.Value;
    }
}