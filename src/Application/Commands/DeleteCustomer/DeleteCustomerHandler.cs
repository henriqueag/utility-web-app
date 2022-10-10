using Application.Extensions;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repository;

namespace Application.Commands.DeleteCustomer;

public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, Unit>
{
    private readonly ICustomerRepository _repository;
    private readonly ILogger<DeleteCustomerHandler> _logger;

    public DeleteCustomerHandler(ICustomerRepository repository, ILogger<DeleteCustomerHandler> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        _logger.LogCommand(nameof(DeleteCustomerCommand), request);

        var customer = await _repository.GetByIdAsync(request.Id, cancellationToken);
        
        if (customer is null)
        {
            throw new UserFriendlyException(
                "delete-customer-command.entity-not-found",
                "Falha na atualização. Cadastro não encontrado");
        }

        if(!IsAllowedDelete(customer))
        {
            throw new UserFriendlyException(
                "customer-repository.not-allowed-deletion",
                "Não é permitido a exclusão de cadastro de cliente que possui vendas relacionadas");            
        }

        await _repository.DeleteAsync(customer, cancellationToken);

        return Unit.Value;
    }

    protected static bool IsAllowedDelete(Customer customer)
    {
        return !customer.SalesOrders.Any();
    }
}