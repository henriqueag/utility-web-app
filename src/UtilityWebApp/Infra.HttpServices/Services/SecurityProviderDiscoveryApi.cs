using System.IdentityModel.Tokens.Jwt;
using System.Web;
using UtilityWebApp.Domain.Services;
using UtilityWebApp.Domain.ValueObjects;
using UtilityWebApp.Infra.HttpServices.Dtos;

namespace UtilityWebApp.Infra.HttpServices.Services;

public class SecurityProviderDiscoveryApi(HttpClient httpClient) : ISecurityProviderDiscoveryApi
{
    public async Task<SecurityProviderDiscoveryMetadata> GetDiscoveryMetadataAsync(string discoveryUri, string username, string password, CancellationToken cancellationToken)
    {
        var document = await ReadDiscoveryDocumentAsync(discoveryUri, cancellationToken);
        var token = await CreateTokenAsync(document.TokenEndpoint, username, password, cancellationToken);
        
        var handler = new JwtSecurityTokenHandler();
        var convertedToken = handler.ReadJwtToken(token.AccessToken);

        var result = new SecurityProviderDiscoveryMetadata(convertedToken.Issuer, convertedToken.Subject)
        {
            LicenseInfoUrl = document.LsInfoUri,
            BusinessObjectConnectorUri = document.BusinessObjectsConnectorUri,
            IntegrationsSetupUri = document.IntegrationsSetupUri
        };

        return result;
    }

    private async Task<DiscoveryDocumentResponse> ReadDiscoveryDocumentAsync(string discoveryUri, CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, discoveryUri);
        var response = await httpClient.SendAsync(request, cancellationToken);
        var document = await response.Content.ReadFromJsonAsync<DiscoveryDocumentResponse>(cancellationToken);

        return document!;
    }

    private async Task<TokenResponse> CreateTokenAsync(string tokenUri, string username, string password, CancellationToken cancellationToken)
    {
        var uriBuilder = new UriBuilder(new Uri(tokenUri, UriKind.Absolute));
        var queryString = HttpUtility.ParseQueryString(uriBuilder.Query);
        queryString["grant_type"] = "password";
        queryString["username"] = username;
        queryString["password"] = password;

        uriBuilder.Query = queryString.ToString();

        var request = new HttpRequestMessage(HttpMethod.Post, uriBuilder.Uri);
        var response = await httpClient.SendAsync(request, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Erro ao gerar o token");
        }

        var token = await response.Content.ReadFromJsonAsync<TokenResponse>(cancellationToken);
        return token!;
    }
}