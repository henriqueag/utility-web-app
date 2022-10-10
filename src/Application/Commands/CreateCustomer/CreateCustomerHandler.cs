using Application.Extensions;
using Domain.Builders;
using Domain.Repository;

namespace Application.Commands.CreateCustomer;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Guid>
{
    private readonly ICustomerRepository _repository;
    private readonly ICustomerBuilder _builder;
    private readonly ILogger<CreateCustomerCommand> _logger;

    public CreateCustomerHandler(ICustomerRepository repository, ICustomerBuilder builder, ILogger<CreateCustomerCommand> logger)
    {
        _repository = repository;
        _builder = builder;
        _logger = logger;
    }

    public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        _logger.LogCommand(nameof(CreateCustomerCommand), request);

        var customer = _builder
            .WithCpf(request.Cpf)
            .FromCustomerData(request)
            .Build();

        await _repository.CreateAsync(customer, cancellationToken);

        return customer.Id;
    }
}
