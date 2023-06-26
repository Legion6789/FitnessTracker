using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Linq;
using BusinessEntities.Models;

namespace BusinessEntities.Authentication
{
    public class AuthManager : IAuthManager
    {
        private readonly UserManager<ApiUser> userManager;
        private readonly IConfiguration configuration;

        private const string loginProvider = "FitnessTracker";
        private const string refreshToken = "RefreshToken";

        private ApiUser user;

        public AuthManager(UserManager<ApiUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        public async Task<IEnumerable<IdentityError>> Register(ApiUserModel userModel)
        {
            user = new ApiUser
            {
                UserName = userModel.Email,
                Email = userModel.Email,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName
            };

            var result = await userManager.CreateAsync(user, userModel.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }

        public async Task<AuthResponseModel> Login(LoginModel loginModel)
        {
            user = await userManager.FindByEmailAsync(loginModel.Email);
            bool isValidUser = await userManager.CheckPasswordAsync(user, loginModel.Password);


            if (user == null || !isValidUser)
            {
                return null;
            }

            var token = await GenerateToken();

            return new AuthResponseModel
            {
                Token = token,
                UserId = user.Id,
                RefreshToken = await CreateRefreshToken()
            };
        }

        private async Task<string> GenerateToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await userManager.GetRolesAsync(user);

            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await userManager.GetClaimsAsync(user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }.Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: configuration["JwtSettings:Issuer"],
                audience: configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(configuration["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public async Task<string> CreateRefreshToken()
        {
            await userManager.RemoveAuthenticationTokenAsync(user, loginProvider, refreshToken);

            var newRefreshToken = await userManager.GenerateUserTokenAsync(user, loginProvider, refreshToken);

            var result = await userManager.SetAuthenticationTokenAsync(user, loginProvider, refreshToken, newRefreshToken);

            return newRefreshToken;
        }

        public async Task<AuthResponseModel> VerifyRefreshToken(AuthResponseModel request)
        {
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var tokenContent = jwtSecurityTokenHandler.ReadJwtToken(request.Token);
            var username = tokenContent.Claims.ToList().ToList().FirstOrDefault(q => q.Type == JwtRegisteredClaimNames.Email)?.Value;
            user = await userManager.FindByNameAsync(username);

            if (user == null || user.Id != request.UserId)
            {
                return null;
            }

            var isValidRefreshToken = await userManager.VerifyUserTokenAsync(user, loginProvider, refreshToken, request.RefreshToken);

            if (isValidRefreshToken)
            {
                var token = await GenerateToken();

                return new AuthResponseModel
                {
                    Token = token,
                    UserId = user.Id,
                    RefreshToken = await CreateRefreshToken()
                };
            }

            await userManager.UpdateSecurityStampAsync(user);

            return null;
        }
    }
}
