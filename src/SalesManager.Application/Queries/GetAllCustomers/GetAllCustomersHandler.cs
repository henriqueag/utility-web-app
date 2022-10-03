using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SalesManager.Application.Dtos;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Repository;

namespace SalesManager.Application.Queries.GetAllCustomers;

public class GetAllCustomersHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<CustomerDetailedData>>
{
    private readonly IRepositoryBase<Customer> _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetAllCustomersHandler> _logger;

    public GetAllCustomersHandler(IRepositoryBase<Customer> repository, IMapper mapper, ILogger<GetAllCustomersHandler> logger)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<IEnumerable<CustomerDetailedData>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
    {
        _logger.LogDebug("Consulta {QueryName} payload: {@QueryPayload}", nameof(GetAllCustomersQuery), request);

        var customers = await _repository.GetAll(cancellationToken);

        return _mapper.Map<IEnumerable<CustomerDetailedData>>(customers);
    }
}
