using System.Text.Json.Serialization;

namespace Application.Commands.UserLogin;

public record UserLoginResponse
{
    public bool Success { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Token { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? ExpiredAt { get; set; }

}

public record UserLoginCommand : IRequest<UserLoginResponse>
{
    public string Email { get; set; }
    public string Password { get; set; }
}

public class UserLoginHandler : IRequestHandler<UserLoginCommand, UserLoginResponse>
{
    public Task<UserLoginResponse> Handle(UserLoginCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
