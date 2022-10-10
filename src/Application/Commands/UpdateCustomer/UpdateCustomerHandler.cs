using Application.Extensions;
using Domain.Builders;
using Domain.Exceptions;
using Domain.Repository;

namespace Application.Commands.UpdateCustomer;

public class DeleteCustomerHandler : IRequestHandler<UpdateCustomerCommand, Unit>
{
    private readonly ICustomerRepository _repository;
    private readonly ICustomerBuilder _builder;
    private readonly ILogger<UpdateCustomerCommand> _logger;

    public DeleteCustomerHandler(ICustomerRepository repository, ICustomerBuilder builder, ILogger<UpdateCustomerCommand> logger)
    {
        _repository = repository;
        _builder = builder;
        _logger = logger;
    }

    public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        _logger.LogCommand(nameof(UpdateCustomerCommand), request);

        var customer = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (customer is null)
        {
            throw new UserFriendlyException(
                "update-customer-command.entity-not-found",
                "Falha na atualização. Cadastro não encontrado");
        }

        var customerUpdated = _builder
            .WithCpf(customer.Cpf)
            .FromCustomerData(request.Data)
            .Build();

        customer.UpdateCustomer(customerUpdated);

        return Unit.Value;
    }
}