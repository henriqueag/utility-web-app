using Application.Commands.RegisterUser;
using Application.Commands.UserLogin;
using Application.Dtos.IdentityData;

namespace Application.Interfaces;

public interface IIdentityService
{
    public Task<UserRegisterResponse> RegisterUser(RegisterUserCommand registerUserRequest, CancellationToken cancellationToken);
    public Task<UserLoginResponse> Login(UserLoginCommand userLoginRequest, CancellationToken cancellationToken);
}
