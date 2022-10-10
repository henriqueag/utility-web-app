namespace Application.Dtos;

public record CustomerData
{
    public string FullName { get; init; }
    public DateTime BirthDate { get; init; }
    public string Phone { get; init; }
    public string Email { get; init; }
}
