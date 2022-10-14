namespace Application.Dtos.Customer;

public record CustomerDetailedData : CustomerData
{
    public Guid Id { get; init; }
    public string Cpf { get; init; }
}