using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SalesManager.Application.Dtos;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Exceptions;
using SalesManager.Domain.Repository;

namespace SalesManager.Application.Queries.GetAllCustomers;

public class GetCustomerHandler : IRequestHandler<GetCustomerQuery, CustomerDetailedData>
{
    private readonly IRepositoryBase<Customer> _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetAllCustomersHandler> _logger;

    public GetCustomerHandler(IRepositoryBase<Customer> repository, IMapper mapper, ILogger<GetAllCustomersHandler> logger)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<CustomerDetailedData> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
    {
        _logger.LogDebug("Consulta {QueryName} payload: {@QueryPayload}", nameof(GetAllCustomersQuery), request);

        var customer = await _repository.GetById(request.Id, cancellationToken);

        return _mapper.Map<CustomerDetailedData>(customer);
    }
}
