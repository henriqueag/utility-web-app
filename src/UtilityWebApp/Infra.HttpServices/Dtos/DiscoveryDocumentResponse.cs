using System.Text.Json.Serialization;

namespace UtilityWebApp.Infra.HttpServices.Dtos;

public class DiscoveryDocumentResponse
{
    [JsonPropertyName("issuer")]
    public string Issuer { get; set; } = null!;

    [JsonPropertyName("token_endpoint")]
    public string TokenEndpoint { get; set; } = null!;

    [JsonPropertyName("jwks_uri")]
    public string JwksUri { get; set; } = null!;

    [JsonPropertyName("current_user_info_uri")]
    public string CurrentUserInfoUri { get; set; } = null!;

    [JsonPropertyName("search_users_uri")]
    public string SearchUsersUri { get; set; } = null!;

    [JsonPropertyName("search_groups_uri")]
    public string SearchGroupsUri { get; set; } = null!;

    [JsonPropertyName("jwt_claims_map_uri")]
    public string? JwtClaimsMapUri { get; set; }

    [JsonPropertyName("ls_info_uri")]
    public string? LsInfoUri { get; set; }

    [JsonPropertyName("businessObjects_connector_uri")]
    public string? BusinessObjectsConnectorUri { get; set; }

    [JsonPropertyName("integrations_setup_uri")]
    public string? IntegrationsSetupUri { get; set; }
}

public class TokenResponse
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = null!;
        
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; set; }
        
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; } = null!;
        
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }
}