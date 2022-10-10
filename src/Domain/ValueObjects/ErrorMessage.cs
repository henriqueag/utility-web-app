namespace Domain.ValueObjects;

public record ErrorMessage
{
    [JsonPropertyOrder(1)]
    [JsonPropertyName("code")]
    public string Code { get; init; }
    
    [JsonPropertyOrder(2)]
    [JsonPropertyName("message")]
    public string Message { get; init; }
}