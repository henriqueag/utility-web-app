using UtilityWebApp.Domain.ValueObjects;

namespace UtilityWebApp.Domain.Services;

public interface ISecurityProviderDiscoveryApi
{
    Task<SecurityProviderDiscoveryMetadata> GetDiscoveryMetadataAsync(string discoveryUri, string username, string password, CancellationToken cancellationToken);
}