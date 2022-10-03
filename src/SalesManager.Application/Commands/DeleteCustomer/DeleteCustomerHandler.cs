using MediatR;
using Microsoft.Extensions.Logging;
using SalesManager.Domain.Exceptions;
using SalesManager.Domain.Repository;

namespace SalesManager.Application.Commands.DeleteCustomer;

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
        _logger.LogInformation("O comando {CommandName} foi solicitado recebendo de entrada o objeto {@Request}", nameof(DeleteCustomerCommand), request);

        var customer = await _repository.GetById(request.Id, cancellationToken);
        
        if (customer is null)
        {
            throw new UserFriendlyException("delete-customer-command.entity-not-found",
                "Falha na atualização. Cadastro não encontrado");
        }

        await _repository.Delete(customer);

        return Unit.Value;
    }
}