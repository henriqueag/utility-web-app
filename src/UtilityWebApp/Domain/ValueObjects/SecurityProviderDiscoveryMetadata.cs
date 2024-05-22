namespace UtilityWebApp.Domain.ValueObjects;

public record SecurityProviderDiscoveryMetadata(string Issuer, string Username)
{
    public string? LicenseInfoUrl { get; init; }
    public string? BusinessObjectConnectorUri { get; init; }
    public string? IntegrationsSetupUri { get; init; }
}