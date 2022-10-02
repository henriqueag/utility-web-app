namespace SalesManager.Application.Dtos;

public record CustomerData
{
    public string FullName { get; init; }
    public string Cpf { get; init; }
    public DateTime BirthDate { get; init; }
    public string Phone { get; init; }
    public string Email { get; init; }
}
