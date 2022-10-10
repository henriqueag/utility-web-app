namespace Domain.ValueObjects;

public record ErrorMessageWithDetails : ErrorMessage
{
    [JsonPropertyOrder(3)]
    [JsonPropertyName("detailedErrors")]
    public IEnumerable<ErrorMessage> DetailedErrors { get; init; }
}