using Microsoft.AspNetCore.Mvc;
using UtilityWebApp.Domain.Services;

namespace UtilityWebApp.Presentation.Controllers;

[ApiController]
[Route("api/security-provider-discovery")]
public class SecurityProviderDiscoveryController : ControllerBase
{
    [HttpPost("metadata")]
    public async Task<IActionResult> GetDiscoveryMetadataAsync(
        [FromServices] ISecurityProviderDiscoveryApi api,
        [FromQuery] string discoveryUri,
        [FromForm] IFormCollection form,
        CancellationToken cancellationToken)
    {
        var (username, password) = (form["username"].ToString(), form["password"].ToString());

        var metadata = await api.GetDiscoveryMetadataAsync(discoveryUri, username, password, cancellationToken);

        return Ok(metadata);
    }
}