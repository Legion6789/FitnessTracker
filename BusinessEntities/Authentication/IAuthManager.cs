using BusinessEntities.Models;
using Microsoft.AspNetCore.Identity;

namespace BusinessEntities.Authentication
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserModel userModel);
        Task<AuthResponseModel> Login(LoginModel loginModel);
        Task<string> CreateRefreshToken();
        Task<AuthResponseModel> VerifyRefreshToken(AuthResponseModel request);
    }
}
