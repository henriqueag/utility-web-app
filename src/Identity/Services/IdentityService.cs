using Application.Commands.RegisterUser;
using Application.Commands.UserLogin;
using Application.Dtos.IdentityData;
using Application.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Identity.Services
{
    internal class IdentityService : IIdentityService
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public IdentityService(
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public Task<UserLoginResponse> Login(UserLoginCommand userLoginRequest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<UserRegisterResponse> RegisterUser(RegisterUserCommand registerUserRequest, CancellationToken cancellationToken)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerUserRequest.Email,
                Email = registerUserRequest.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(identityUser, registerUserRequest.Password);
            if (result.Succeeded)
                await _userManager.SetLockoutEnabledAsync(identityUser, enabled: false);

            var response = new UserRegisterResponse(sucesso: result.Succeeded);
            if (!result.Succeeded && result.Errors.Any())
                response.AddErrors(result.Errors.Select(x => x.Description));

            return response;
        }
    }
}
