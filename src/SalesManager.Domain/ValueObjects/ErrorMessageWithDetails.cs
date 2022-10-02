using System.Text.Json.Serialization;

namespace SalesManager.Domain.ValueObjects;

public record ErrorMessageWithDetails : ErrorMessage
{
    [JsonPropertyOrder(3)]
    public IEnumerable<ErrorMessage> DetailedErrors { get; init; }
}