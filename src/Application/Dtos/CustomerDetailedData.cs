namespace Application.Dtos;

public record CustomerDetailedData : CustomerData
{
    public Guid Id { get; init; }
    public string Cpf { get; init; }
}