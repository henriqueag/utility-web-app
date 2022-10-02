using System.Text.Json.Serialization;

namespace SalesManager.Domain.ValueObjects;

public record ErrorMessage
{
    [JsonPropertyOrder(1)]
    public string Code { get; init; }
    
    [JsonPropertyOrder(2)]
    public string Message { get; init; }
}