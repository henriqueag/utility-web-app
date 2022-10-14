using Application.Dtos.IdentityData;

namespace Application.Commands.RegisterUser;

public record RegisterUserCommand : IRequest<UserRegisterResponse>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string PasswordConfirmation { get; set; }
}

public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, UserRegisterResponse>
{
    public Task<UserRegisterResponse> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}