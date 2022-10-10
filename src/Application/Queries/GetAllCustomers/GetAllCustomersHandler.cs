using Application.Dtos;
using Application.Extensions;
using Domain.Entities;
using Domain.Repository;

namespace Application.Queries.GetAllCustomers;

public class GetAllCustomersHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<CustomerDetailedData>>
{
    private readonly ICustomerRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetAllCustomersHandler> _logger;

    public GetAllCustomersHandler(ICustomerRepository repository, IMapper mapper, ILogger<GetAllCustomersHandler> logger)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<IEnumerable<CustomerDetailedData>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
    {
        _logger.LogQuery(nameof(GetAllCustomersQuery), request);

        var customers = await GetCustomersAsync(request, cancellationToken);

        return _mapper.Map<IEnumerable<CustomerDetailedData>>(customers);
    }

    private async Task<IEnumerable<Customer>> GetCustomersAsync(GetAllCustomersQuery request, CancellationToken cancellationToken)
    {
        var customers = await _repository.GetAllAsync(cancellationToken);

        if(!string.IsNullOrEmpty(request.FullName) && request.FullName.Length >= 3)
        {
            customers = customers.Where(x => x.FullName.ToLower().Contains(request.FullName.ToLower()));
        }

        return customers;
    }
}
